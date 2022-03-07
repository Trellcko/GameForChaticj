using House312B.Core;
using UnityEngine;

namespace House312B.Physics
{
    public class Mover : MonoBehaviour, IMover
    {
        [Range(0, 0.1f)]
        [SerializeField] private float _speed;

        [SerializeField] private Rigidbody2D _rigidbody2D;

        public void Move(Vector2 force)
        {
            _rigidbody2D.MovePosition(_rigidbody2D.position + force * _speed);
        }
    }
}