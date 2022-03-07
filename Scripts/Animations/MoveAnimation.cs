using UnityEngine;

namespace House312B.Animation
{
    public class MoveAnimation : BaseAnimation
    {
        private const string SpeedAtributeName = "speed";

        public MoveAnimation(Animator animator) : base(animator)
        {
        }

        public void PlayIdleAnimation()
        {
            SetSpeed(0);
        }

        public void PlayWalkAnimation()
        {
            SetSpeed(1);
        }

        private void SetSpeed(float speed)
        {
            _animator.SetFloat(SpeedAtributeName, speed);
        }
    }
}