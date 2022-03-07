using System;
using Trell.ShadowHouse.Player;
using UnityEngine;

namespace Trell
{
	public class MonsterCollisionDetector : MonoBehaviour
	{
        public event Action WallDetected;

        public event Action<Health> PlayerHealthDetected;
        public event Action PlayerDetected;
        
        private readonly string _wallTag = "Wall";

        private void OnCollisionEnter2D(Collision2D coll)     
        {
            if (coll.gameObject.CompareTag(_wallTag))
            {
                WallDetected?.Invoke();
            }

            if (coll.gameObject.TryGetComponent(out Health health))
            {
                PlayerHealthDetected?.Invoke(health);
                PlayerDetected?.Invoke();
            }
        }
    }
}