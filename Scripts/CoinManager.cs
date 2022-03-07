using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Trell
{
	public class CoinManager : MonoBehaviour
	{
		[SerializeField] private PlayerEvents _playerEvents;
        [SerializeField] private List<Coin> _coins;

        private int _currentActiveCoinIndex = 0;

        [SerializeField] private TextMeshProUGUI _text;

        private void Start()
        {
            for(int i = 1; i < _coins.Count; i++)
            {
                _coins[i].gameObject.SetActive(false);
            }
        }

        private void OnEnable()
        {
            _playerEvents.BringTheCoin += ActiveNextCoint;
        }

        private void OnDisable()
        {
            _playerEvents.BringTheCoin -= ActiveNextCoint;
        }

        private void ActiveNextCoint()
        {
            if(++_currentActiveCoinIndex >= _coins.Count)
            {
                SceneManager.LoadScene(1);
            }
            _coins[_currentActiveCoinIndex].gameObject.SetActive(true);
        }
    }
}