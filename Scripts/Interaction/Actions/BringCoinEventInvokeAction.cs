using House312B.Core;
using UnityEngine;

namespace Trell
{
    public class BringCoinEventInvokeAction : MonoBehaviour, IAction
    {
        [SerializeField] private PlayerEvents _playerEvents;
        public void Do()
        {
            _playerEvents.BringTheCoinInvoke();
        }
    }
}