using System.Linq;
using Unity.WebRTC;
using UnityEngine;

namespace Unity.RenderStreaming
{
    public class AmbientStreamer : AudioStreamBase
    {
        [SerializeField, Tooltip("AudioSource")]
        private AudioSource audioSource;

        protected virtual void OnEnable()
        {
            if (audioSource == null)
            {
                Debug.LogFormat("AudioSource required");
                return;
            }
        }

        protected virtual void OnDisable()
        {
            if (audioSource == null)
            {
                return;
            }

            audioSource.Stop();
            //audioSource.clip = null;
        }

        protected override MediaStreamTrack CreateTrack()
        {
            return new AudioStreamTrack(audioSource);
        }
    }
}