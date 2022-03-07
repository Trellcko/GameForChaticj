using House312B.Audio;
using Trell.ShadowHouse.Input;
using UnityEngine;

namespace House312B.Player
{
    public class AudioPlayer : MonoBehaviour
    {
        [SerializeField] private AudioClip _movementAudio;

        private void OnEnable()
        {
            Subscibe();
        }

        private void OnDisable()
        {
            UnSubscibe();
        }

        public void Subscibe()
        {
            InputHandler.Instace.PlayerMovement.performed += OnPlayerMovementPerformed;
            InputHandler.Instace.PlayerMovement.canceled += OnPlayerMovementCanceled;
        }


        public void UnSubscibe()
        {
            InputHandler.Instace.PlayerMovement.performed -= OnPlayerMovementPerformed;
            InputHandler.Instace.PlayerMovement.canceled -= OnPlayerMovementCanceled;
        }


        public void PlayMovementSound()
        {
            AudioManager.Instance.Play(_movementAudio,true);
        }

        public void StopPlayMovementSound()
        {
            AudioManager.Instance.StopPlay(_movementAudio);
        }

        private void OnPlayerMovementCanceled(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            StopPlayMovementSound();
        }

        private void OnPlayerMovementPerformed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            PlayMovementSound();
        }


    }
}