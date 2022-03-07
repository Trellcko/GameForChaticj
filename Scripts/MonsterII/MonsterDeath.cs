using System;
using UnityEngine;

namespace Trell.ShadowHouse.II
{
	public class MonsterDeath : MonoBehaviour
	{
		[SerializeField] private MonsterCollisionDetector _monsterCollisionDetector;

        public event Action Died;

        private void OnEnable()
        {
            _monsterCollisionDetector.PlayerDetected += Die;
        }

        private void OnDisable()
        {
            _monsterCollisionDetector.PlayerDetected -= Die;
        }

        public void Die()
        {
            Died?.Invoke();
            Destroy(gameObject);
        }
    }
}