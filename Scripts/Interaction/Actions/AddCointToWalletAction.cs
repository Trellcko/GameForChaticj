using House312B.Core;
using UnityEngine;

namespace Trell
{
    public class AddCointToWalletAction : MonoBehaviour, IAction
    {
        [SerializeField] private Wallet _wallet;
        public void Do()
        {
            _wallet.AddCoin();
        }
    }
}