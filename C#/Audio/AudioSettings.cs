using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

namespace HongryBerry
{

    public class AudioSettings : MonoBehaviour
    {

        public AudioMixer am;
        private bool soundOff = false;
        private float multeSound = -80f;
        private float maxSound = 0f;

        public void SetVolume(float volume)
        {
            am.SetFloat("volume", volume);
        }
    }
}
