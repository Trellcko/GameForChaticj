using UnityEngine;
using House312B.Core;

namespace House312B.Interaction.Actions
{
    public class ChangeOrderInLayerAction : MonoBehaviour, IAction
    {
        [SerializeField] private SpriteRenderer _renderer;

        [SerializeField] private int _newOrder = 0;

        public void Do()
        {
            _renderer.sortingOrder = _newOrder;
        }
    }
}