using House312B.Physics;
using UnityEngine;

namespace Trell.ShadowHouse.II
{
    public class MonsterMoving : MonoBehaviour
    {
        [SerializeField] private Mover _mover;
        [SerializeField] private MonsterCollisionDetector _collisionDetector;


        [SerializeField] private Vector2 _direct = Vector2.left;

        public bool IsActive { get; private set; }

        void Start()
        {
            Active();
        }

        private void OnEnable()
        {
            _collisionDetector.WallDetected += WallDetectedHandler;
        }

        private void OnDisable()
        {
            _collisionDetector.WallDetected -= WallDetectedHandler;
        }
        private void WallDetectedHandler()
        {
            SetDirect(_direct * -1);
        }

        private void Update()
        {
            if (IsActive)
            {
                _mover.Move(_direct * transform.localScale);
            }
        }

        public void SetDirect(Vector2 direct)
        {
            _direct = direct;
        }

        public void Active()
        {
            IsActive = true;
        }
        public void DeActive()
        {
            IsActive = false;
        }
    }
}