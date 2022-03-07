using House312B.TransformModule;
using UnityEngine;

namespace Trell.ShadowHouse.II
{
	public class MonsterFlipping : MonoBehaviour
	{
		[SerializeField] private MonsterCollisionDetector collisionDetector;
        [SerializeField] private Flipper _flipper;

        private void OnEnable()
        {
            collisionDetector.WallDetected += Flip;
        }

        private void OnDisable()
        {
            collisionDetector.WallDetected -= Flip;
        }

        public void Flip()
        {
            _flipper.Flip();
        }
    }
}