using System;
using UnityEngine;

namespace Trell
{
	[CreateAssetMenu(fileName = "New PlayerEvenets", menuName = "GamePlay/PlayerEvents", order = 41)]
	public class PlayerEvents : ScriptableObject
	{
		public event Action PlayerHide;
		public event Action PlayerChangeFloor;
		public event Action BringTheCoin;

		public void BringTheCoinInvoke()
        {
			BringTheCoin?.Invoke();
        }

		public void PlayerHideInvoke()
        {
			PlayerHide?.Invoke();
        }

		public void PlayerChangeFloorInvoke()
        {
			PlayerChangeFloor?.Invoke();
        }
	}
}