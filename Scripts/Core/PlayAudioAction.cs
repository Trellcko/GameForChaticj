using UnityEngine;
using House312B.Core;
using House312B.Audio;

namespace House312B.Interaction.Actions
{
    public class PlayAudioAction : MonoBehaviour, IAction
    {
        [SerializeField] private AudioClip _audioClip;
        [SerializeField] private bool _isLoop = false;
        public void Do()
        {
            AudioManager.Instance.Play(_audioClip, _isLoop);
        }
    }
}