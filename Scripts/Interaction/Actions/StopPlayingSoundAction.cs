using UnityEngine;
using House312B.Core;
using House312B.Audio;

namespace House312B.Interaction
{
    public class StopPlayingSoundAction : MonoBehaviour, IAction
    {
        [SerializeField] private AudioClip _audioClip;
        public void Do()
        {
            AudioManager.Instance.StopPlay(_audioClip);
        }
    }
}