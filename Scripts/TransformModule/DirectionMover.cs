using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace House312B.TransformModule
{
    public class DirectionMover : MonoBehaviour
    {
        [SerializeField] private Vector2 _direction;
        [SerializeField] private float _speed;
        [SerializeField] private bool _isMoving;

        public void Enable()
        {
            _isMoving = true;
        }

        public void Disable()
        {
            _isMoving = false;
        }

        private void Update()
        {
            transform.Translate(_direction * _speed * Time.deltaTime);
        }
    }
}