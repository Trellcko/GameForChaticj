using UnityEngine;
using Trell.ShadowHouse.Input;
using Trell.ShadowHouse.Core;

namespace Trell.ShadowHouse.Player
{
    public class FlashLigthController : MonoBehaviour, IInputSubscriber
	{
		[SerializeField] private FlashLigth _flashLigth;

        public void OnEnable()
        {
            Subscribe();
        }

        private void OnDisable()
        {
            UnSubscribe();
        }

        public void Subscribe()
        {
            InputHandler.Instace.PlayerFlashLigth.performed += TurnOnFlashLigth;
            InputHandler.Instace.PlayerFlashLigth.canceled += TurnOffFlashLigth;
        }

        public void UnSubscribe()
        {
            InputHandler.Instace.PlayerFlashLigth.performed -= TurnOnFlashLigth;
            InputHandler.Instace.PlayerFlashLigth.canceled -= TurnOffFlashLigth;
            _flashLigth.TurnOff();
        }

        private void TurnOffFlashLigth(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            _flashLigth.TurnOff();
        }

        private void TurnOnFlashLigth(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            _flashLigth.TryTurnOn();
        }
    }
}