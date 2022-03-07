using House312B.Utils;
using UnityEngine;

namespace House312B.Animation
{
    public class BaseAnimation
    {
        protected Animator _animator;

        public BaseAnimation(Animator animator)
        {
            _animator = animator;
            QuickAssert.AssertIsNotNullAfterAssigment(_animator);
        }
    }
}