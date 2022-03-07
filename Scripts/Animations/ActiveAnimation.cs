using House312B.Utils;
using UnityEngine;

namespace House312B.Animation
{
    public class ActiveAnimation : BaseAnimation
    {

        private const string ShowTriggerName = "Show";
        private const string HideTriggerName = "Hide";

        public ActiveAnimation(Animator animator) : base(animator) { }

        public void PlayShowAnimation()
        {
            _animator.SetTrigger(ShowTriggerName);
            _animator.ResetTrigger(HideTriggerName);
        }

        public void PlayHideAnimation()
        {
            _animator.SetTrigger(HideTriggerName);
            _animator.ResetTrigger(ShowTriggerName);
        }
    }
}