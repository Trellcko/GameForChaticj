using Sirenix.OdinInspector;
using System;
using System.Collections.Generic;
using Trell.ShadowHouse.Core;
using Trell.ShadowHouse.Input;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Trell
{
    public class Restarter : SerializedMonoBehaviour
    {

        private void OnEnable()
        {
            InputHandler.Instace.Pasuse.performed += PauseKeyClik;
        }

        private void OnDisable()
        {
            InputHandler.Instace.Pasuse.performed += PauseKeyClik;
        }
        private void PauseKeyClik(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            SceneManager.LoadScene(0);
        }
    }
}