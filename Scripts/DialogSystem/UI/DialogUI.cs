using House312B.Animation;
using House312B.Utils;
using TMPro;
using UnityEngine;

namespace House312B.DialogSystem.UI
{
    public class DialogUI : MonoBehaviour
    {

        [SerializeField] private Animator _animator;
     
        [SerializeField] private TextMeshProUGUI _textBox;

        [SerializeField] private Transform _attachPoint;
        public ActiveAnimation Animator { get; private set; }

        private void Start()
        {
            QuickAssert.AssertIsNotNullAfterAssigment(_animator);
            QuickAssert.AssertIsNotNullAfterAssigment(_textBox);
            QuickAssert.AssertIsNotNullAfterAssigment(_attachPoint);

            Animator = new ActiveAnimation(_animator);
        }

        public void AttachTo(Vector2 position)
        {
            _attachPoint.position = position;
        }

        public void Display(string text)
        {
            _textBox.SetText(text);
        }
    }
}