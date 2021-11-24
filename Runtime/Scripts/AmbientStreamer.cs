using System.Linq;
using Unity.WebRTC;
using UnityEngine;

namespace Unity.RenderStreaming
{
    public class AmbientStreamer : AudioStreamBase
    {
        protected override MediaStreamTrack CreateTrack()
        {
            return new AudioStreamTrack();
        }
    }
}