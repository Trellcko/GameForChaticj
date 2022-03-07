using House312B.Core;
using House312B.InventorySystem;
using House312B.Utils;
using UnityEngine;

namespace House312B.Interaction.Actions
{

    public class RemoveItemFromInventoryAction : MonoBehaviour, IAction
    {
        [SerializeField] private ItemData _itemData;

        private Inventory _inventory;

        private void Awake()
        {
            _inventory = FindObjectOfType<Inventory>();
            QuickAssert.AssertIsNotNullAfterFind(_inventory);
        }

        public void Do()
        {
            _inventory.RemoveItem(_itemData);
        }

        public void Reset()
        {

        }
    }
}