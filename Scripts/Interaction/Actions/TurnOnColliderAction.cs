using UnityEngine;
using House312B.Core;

namespace House312B.Interaction.Actions
{
    public class TurnOnColliderAction : MonoBehaviour, IAction
    {
        [SerializeField] Collider2D _collider2D;
        public void Do()
        {
            _collider2D.enabled = true;
        }
    }
}