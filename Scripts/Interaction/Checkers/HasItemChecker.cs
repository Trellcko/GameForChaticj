using UnityEngine;

using House312B.Core;
using House312B.InventorySystem;
using UnityEngine.Assertions;
using House312B.Interaction.Actions;
using House312B.Utils;

namespace House312B.Interaction.Checkers
{
    public class HasItemChecker : MonoBehaviour, IChecker
    {
        [SerializeField] private ItemData _itemData;

        private Inventory _inventory;


        private void Awake()
        {
            _inventory = FindObjectOfType<Inventory>();
            QuickAssert.AssertIsNotNullAfterAssigment(_inventory);
        }

        public bool Check()
        {
            return _inventory.Has(_itemData);
        }
    }
}