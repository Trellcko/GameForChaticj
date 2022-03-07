using UnityEngine;
using House312B.Core;
using House312B.Utils;

namespace House312B.Interaction.Actions
{
    public class ChangeSpriteAction : MonoBehaviour, IAction
    {
        [SerializeField] private SpriteRenderer _target;
        [SerializeField] private Sprite _newSprite;

        private void Start()
        {
            QuickAssert.AssertIsNotNullAfterAssigment(_target);
            QuickAssert.AssertIsNotNullAfterAssigment(_newSprite);
        }

        public void Do()
        {
            _target.sprite = _newSprite;
        }

    }
}