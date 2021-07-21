using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HongryBerry
{
    public class Vibrator : MonoBehaviour
    {
        public static void Vibrate()
        {
            Handheld.Vibrate();
        }
    }
}