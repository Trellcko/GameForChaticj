using UnityEngine;
using UnityEngine.InputSystem;
using Sirenix.OdinInspector;
using House312B.Core;
using House312B.Utils;
using Trell.ShadowHouse.Input;
using Trell.ShadowHouse.Core;

namespace House312B.Player
{
    public class Movement : SerializedMonoBehaviour , IInputSubscriber
    {
        [SerializeField] private IMover _mover;

        private float _xInput = 0f;

        private void Start()
        {
            QuickAssert.AssertIsNotNullAfterAssigment(_mover);
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
            InputHandler.Instace.PlayerMovement.performed -= Move;
            InputHandler.Instace.PlayerMovement.canceled -= StopMoving;
            _xInput = 0;
        }

        public void Subscribe()
        {
            InputHandler.Instace.PlayerMovement.performed += Move;
            InputHandler.Instace.PlayerMovement.canceled += StopMoving;
        }

        private void FixedUpdate()
        {
            _mover.Move(new Vector2(_xInput, 0));
        }

        private void StopMoving(InputAction.CallbackContext callBack)
        {
            _xInput = 0;
        }

        private void Move(InputAction.CallbackContext callBack)
        {
            _xInput = callBack.ReadValue<float>();
        }
    }
}