using House312B.Core;
using House312B.InventorySystem;
using UnityEngine;
using House312B.Utils;

namespace House312B.Interaction.Actions
{
    public class AddItemToInventoryAction : MonoBehaviour, IAction
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
            _inventory.AddItem(_itemData);
        }
    }
}