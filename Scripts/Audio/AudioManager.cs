using System;
using UnityEngine;

namespace House312B.Audio
{
    public class AudioManager : MonoBehaviour
    {
        public static AudioManager Instance
        {
            get
            {
                if (s_instance == null)
                {
                    s_instance = new GameObject(nameof(AudioManager)).AddComponent<AudioManager>();
                }
                return s_instance;
            }
        }

        public const int AudioSourecCount = 3;

        private static AudioManager s_instance;

        public void StopPlay(AudioClip audioClip)
        {
            for (int i = 0; i < _audioSources.Length; i++)
            {
                if (_audioSources[i].clip == audioClip && _audioSources[i].isPlaying)
                {
                    _audioSources[i].Stop();
                    break;
                }
            }
        }

        private AudioSource[] _audioSources = new AudioSource[AudioSourecCount];

        private void Awake()
        {
            if (FindObjectsOfType<AudioManager>().Length > 1)
            {
                Destroy(gameObject);
            }

            for (int i = 0; i < AudioSourecCount; i++)
            {
                _audioSources[i] = gameObject.AddComponent<AudioSource>();
            }
            DontDestroyOnLoad(this);
        }

        public void Play(AudioClip audioClip, bool loop = false)
        {
            for (int i = 0; i < _audioSources.Length; i++)
            {
                if (_audioSources[i].isPlaying)
                {
                    if(_audioSources[i].clip == audioClip)
                    {
                        _audioSources[i].loop = loop;
                        break;
                    }
                    continue;
                }
                _audioSources[i].clip = audioClip;
                _audioSources[i].Play();
                _audioSources[i].loop = loop;
                break;
            }
        }
    }
}