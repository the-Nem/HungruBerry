using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HongryBerry
{
    public class CandyClass : MonoBehaviour, InterfaceColliders
    {
        public void I_CandyAction()
        {
            Destroy(gameObject);
            Sc_Audio.instance.FartCount++;
            Sc_Audio.instance.CaloryCount++;
            The_Score.instance.CandyCalculation(1);
            GameManager.instance.AffectToEatedCandys(1);
            Vibrator.Vibrate();
        }
        private void Awake()
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}