using House312B.Core;
using UnityEngine;

namespace Trell
{
    public class HasCointChecker : MonoBehaviour, IChecker
    {
        [SerializeField] private Wallet _wallet;
        public bool Check()
        {
            return _wallet.HasCoin;
        }
    }
}