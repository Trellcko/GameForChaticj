using House312B.DialogSystem;
using House312B.Core;
using UnityEngine;
using House312B.Utils;

namespace House312B.Interaction.Actions
{
    public class ShowDialogInteractionAction : MonoBehaviour, IAction
    {
        [SerializeField] private Dialog _dialog;
        private void Start()
        {
            QuickAssert.AssertIsNotNullAfterAssigment(_dialog);
        }

        public void Do()
        {
            _dialog.ShowNext();
        }
    }
}