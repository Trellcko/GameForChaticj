using House312B.Core;
using House312B.Utils;
using Sirenix.OdinInspector;
using Trell.ShadowHouse.Input;
using Trell.ShadowHouse.Core;
using UnityEngine;

namespace House312B.Player
{
    public class Flipping : SerializedMonoBehaviour, IInputSubscriber
    {
        [SerializeField] private IFlipper _flipper;

        private bool _isPositiveDirection = true;

        private void Start()
        {
            QuickAssert.AssertIsNotNullAfterAssigment(_flipper);    
        }

        private void OnEnable()
        {
            Subscribe();
        }


        private void OnDisable()
        {
            UnSubscribe();
        }

        public void Subscribe()
        {
            InputHandler.Instace.PlayerMovement.performed += Flip;
        }


        public void UnSubscribe()
        {
            InputHandler.Instace.PlayerMovement.performed -= Flip;
        }

        private void Flip(UnityEngine.InputSystem.InputAction.CallbackContext callback)
        {
            float readX = callback.ReadValue<float>();
           
            if(readX > 0 ^ _isPositiveDirection == true)
            {
                _flipper.Flip();
                _isPositiveDirection = !_isPositiveDirection;
            }

        }
    }
}