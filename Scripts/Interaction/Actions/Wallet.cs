using UnityEngine;

namespace Trell
{
	public class Wallet : MonoBehaviour
	{
		private int _coins = 0;

		public bool HasCoin => _coins > 0;

		public void AddCoin()
        {
			_coins++;
        }

		public void TakeCoin()
        {
			if(_coins > 0)
            {
				_coins--;
            }
        }
	}
}