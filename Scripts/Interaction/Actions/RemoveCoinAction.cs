using House312B.Core;
using UnityEngine;

namespace Trell
{
    public class RemoveCoinAction : MonoBehaviour, IAction
    {
        [SerializeField] private Wallet _wallet;
        public void Do()
        {
            _wallet.TakeCoin();
        }
    }
}