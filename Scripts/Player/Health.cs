using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Trell.ShadowHouse.Player
{
	public class Health : MonoBehaviour
	{
		[SerializeField] private int _maxHealth;
		
		private int _currentHealth = 0;

        public event Action DamageTaked;
        public event Action Died;

        private void Start()
        {
            _currentHealth = _maxHealth;
        }

        public void TakeDamage()
        {
            _currentHealth--;
            if (_currentHealth <= 0)
            {
                Died?.Invoke();
                SceneManager.LoadScene(2);
            }
            DamageTaked?.Invoke();
        }
    }
}