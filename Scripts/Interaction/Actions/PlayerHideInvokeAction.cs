using House312B.Core;
using UnityEngine;

namespace Trell
{
	public class PlayerHideInvokeAction : MonoBehaviour, IAction
	{
		[SerializeField] PlayerEvents _playerEvents;

        public void Do()
        {
            _playerEvents.PlayerHideInvoke();
        }
    }
}