using UnityEngine;
using House312B.Animation;
using House312B.Utils;
using Trell.ShadowHouse.Input;
using Trell.ShadowHouse.Core;

namespace House312B.Player
{
    public class AnimatorHandler : MonoBehaviour,IInputSubscriber
    {
        [SerializeField] private Animator _animator;

        private MoveAnimation _moveAnimation;

        private void Start()
        {
            QuickAssert.AssertIsNotNullAfterAssigment(_animator);
            _moveAnimation = new MoveAnimation(_animator);
        }

        private void OnEnable()
        {
            Subscribe();
        }
        private void OnDisable()
        {
            UnSubscribe();
        }

        public void UnSubscribe()
        {
            InputHandler.Instace.PlayerMovement.performed -= OnPlayerMovementPerformed;
            InputHandler.Instace.PlayerMovement.canceled -= OnPlayerMovementCanceled;
            _moveAnimation.PlayIdleAnimation();
        }

        public void Subscribe()
        {
            InputHandler.Instace.PlayerMovement.performed += OnPlayerMovementPerformed;
            InputHandler.Instace.PlayerMovement.canceled += OnPlayerMovementCanceled;
            
        }

        private void OnPlayerMovementCanceled(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            _moveAnimation.PlayIdleAnimation();
        }

        private void OnPlayerMovementPerformed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            _moveAnimation.PlayWalkAnimation();
        }

    }
}