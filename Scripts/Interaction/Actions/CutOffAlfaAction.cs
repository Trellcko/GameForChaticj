using UnityEngine;
using House312B.Core;

namespace House312B.Interaction.Actions
{
    public class CutOffAlfaAction : MonoBehaviour, IAction
    {
        [SerializeField] private SpriteRenderer _render;
        
        [Range(0,1f)]
        [SerializeField] private float _newAlfa = 1f;
        public void Do()
        {
            Color color = _render.color;
            color.a = _newAlfa;
            _render.color = color;
        }
    }
}