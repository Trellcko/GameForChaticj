using UnityEngine;

namespace House312B.InventorySystem
{
    [CreateAssetMenu(fileName = "new ItemData", menuName = "InventorySyste/ItemData", order = 41)]
    public class ItemData : ScriptableObject
    {
        [field: SerializeField] public string Name { get; }
    }
}