using UnityEngine;
using House312B.Core;
using House312B.Utils;

namespace House312B.Interaction.Actions
{
    public class TurnOffColliderAction : MonoBehaviour, IAction
    {
        [SerializeField] private Collider2D _collider2D;
        private void Start()
        {
            QuickAssert.AssertIsNotNullAfterAssigment(_collider2D);
        }

        public void Do()
        {
            _collider2D.enabled = false;
        }
    }
}