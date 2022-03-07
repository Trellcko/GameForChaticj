using System.Collections.Generic;
using UnityEngine;

namespace House312B.InventorySystem
{
    public class Inventory : MonoBehaviour
    {
        private List<ItemData> _itemData = new List<ItemData>();

        public void RemoveItem(ItemData itemData)
        {
            if (Has(itemData))
            {
                _itemData.Remove(itemData);
            }
        }
        public bool Has(ItemData item)
        {
            return _itemData.Contains(item);
        }

        public void AddItem(ItemData itemData)
        {
            _itemData.Add(itemData);
        }
    }
}