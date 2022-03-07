using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

using House312B.Core;
using House312B.Animation;
using House312B.Utils;

namespace House312B.Interaction.Checkers
{
    public class Key : MonoBehaviour, IChecker
    {
        [SerializeField] private KeyCode _keyCode;
        [SerializeField] private Animator _animator;

        public ActiveAnimation ActiveAnimations { get; private set; }

        private KeyControl _keyControll;

        private void Awake()
        {
            _keyControll ??= Keyboard.current.FindKeyOnCurrentKeyboardLayout(_keyCode.ToString());
            Assert.AreNotEqual(_keyControll, null, $"Didn't find key with name {_keyCode}");
        }

        private void Start()
        {
            QuickAssert.AssertIsNotNullAfterAssigment(_animator);
            ActiveAnimations = new ActiveAnimation(_animator);
        }

        public bool Check()
        {

            return _keyControll.wasPressedThisFrame;
        }
    }
}