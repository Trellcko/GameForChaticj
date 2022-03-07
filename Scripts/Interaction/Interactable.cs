using House312B.Interaction.Checkers;
using Sirenix.OdinInspector;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace House312B.Interaction
{
    public class Interactable : SerializedMonoBehaviour
    {
        [SerializeField] private List<ActionsInfo> _interactActionsInfo;

        [SerializeField] private List<ActionsInfo> _disableActionsInfo;

        [SerializeField] private List<ActionsInfo> _enableActionsInfo;

        [SerializeField] private List<Key> _key;

        private bool _isInteracting = false;

        private void Start()
        {
            Assert.AreEqual(_key.Count, _interactActionsInfo.Count, "Key animatiors count are not equal interaction data count");
        }

        public void Update()
        {
            if (_isInteracting)
            {
                TryDoActions(_interactActionsInfo);
            }
        }

        public void EnableInteraction()
        {
            _isInteracting = true;
            ShowInteractionKeysImage();
            TryDoActions(_enableActionsInfo);
        }

        public void DisableInteraction()
        {
            _isInteracting = false;
            HideInteractionKeysImage();
            TryDoActions(_disableActionsInfo);


        }

        public void TryDoActions(List<ActionsInfo> interactionInfo)
        {
            foreach (var interactInfo in interactionInfo)
            {
                interactInfo.TryDoActions();
            }
        }



        private void ShowInteractionKeysImage()
        {
            foreach (var interactionKey in _key)
            {
                interactionKey.ActiveAnimations.PlayShowAnimation();
            }
        }

        private void HideInteractionKeysImage()
        {
            foreach (var interactionKey in _key)
            {
                interactionKey.ActiveAnimations.PlayHideAnimation();
            }
        }
    }
}