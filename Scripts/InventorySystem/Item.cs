using UnityEngine;

namespace House312B.InventorySystem
{
    public class Item : MonoBehaviour
    {
        [field: SerializeField] public ItemData ItemData { get; }
    }
} 