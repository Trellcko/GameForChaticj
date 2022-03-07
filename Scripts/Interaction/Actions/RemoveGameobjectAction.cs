using House312B.Core;
using UnityEngine;
using House312B.Utils;

namespace House312B.Interaction.Actions
{
    public class RemoveGameobjectAction : MonoBehaviour, IAction
    {
        [SerializeField] private GameObject _target;

        private void Start()
        {
            QuickAssert.AssertIsNotNullAfterAssigment(_target);
        }

        public void Do()
        {
            Destroy(_target);
        }
    }
}