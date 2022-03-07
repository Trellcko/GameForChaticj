using Trell.ShadowHouse.Player;
using UnityEngine;

namespace Trell.ShadowHouse.GamePlay
{
	public class MonsterTakeDamage : MonoBehaviour
	{
        [Min(0)]
		[SerializeField] private int _damage;
		[SerializeField] private MonsterCollisionDetector _collisionDetector;

		private Health _playerHealth;

        private void Awake()
        {
            _playerHealth = FindObjectOfType<Health>();
            _collisionDetector.PlayerHealthDetected += GiveDamage;
        }

        private void GiveDamage(Health health)
        {
            for (int i = 0; i < _damage; i++)
            {
                health.TakeDamage();
            }
        }
    }
}