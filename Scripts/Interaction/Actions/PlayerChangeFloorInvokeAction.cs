using UnityEngine;
using House312B.Core;
namespace Trell
{
    public class PlayerChangeFloorInvokeAction : MonoBehaviour, IAction
    {
        [SerializeField] PlayerEvents _playerEvents;
        public void Do()
        {
            _playerEvents.PlayerChangeFloorInvoke();
        }
    }
}