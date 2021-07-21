using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HongryBerry
{
    public class PepperClass : MonoBehaviour, InterfaceColliders
    {

        public void I_CandyAction()
        {
            Destroy(gameObject);
            Sc_Audio.instance.PlayEatPepper();
            The_Score.instance.LooseLive(-1);
            GameManager.instance.AffectToEatedCandys(1);
            Vibrator.Vibrate();
            //add particle sys

        }
        private void Awake()
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}

