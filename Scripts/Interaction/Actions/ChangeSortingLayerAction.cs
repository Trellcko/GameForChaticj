using UnityEngine;
using House312B.Core;


namespace House312B.Interaction.Actions
{
    public class ChangeSortingLayerAction : MonoBehaviour, IAction
    {
        [SerializeField] private SpriteRenderer _spriteRender;

        [Min(0)]
        [SerializeField] private int _newLayer;

        public void Do()
        {
            _spriteRender.renderingLayerMask = (uint)_newLayer;
        }
    }
}