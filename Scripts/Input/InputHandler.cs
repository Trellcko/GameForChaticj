using UnityEngine;
using UnityEngine.InputSystem;

namespace Trell.ShadowHouse.Input
{
    public class InputHandler : MonoBehaviour
    {
        public static InputHandler Instace
        {
            get
            {
                if (s_instance == null)
                {
                    s_instance = new GameObject(nameof(InputHandler)).AddComponent<InputHandler>();
                }
                return s_instance;
            }
        }

        public InputAction PlayerFlashLigth => _inputController.Player.FlashLigth;
        public InputAction PlayerMovement => _inputController.Player.Movement;

        public InputAction Pasuse => _inputController.Controll.Pause;
        
        private static InputHandler s_instance;

        private InputController _inputController;


        private void Awake()
        {
            if (FindObjectsOfType<InputHandler>().Length > 1)
            {
                Destroy(gameObject);
            }
            _inputController = new InputController();
            _inputController.Enable();
            DontDestroyOnLoad(this);
        }
    }
}