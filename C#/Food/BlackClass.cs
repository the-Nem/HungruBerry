using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HongryBerry
{

    public class BlackClass : MonoBehaviour, InterfaceColliders
    {
        public void I_CandyAction()
        {
            Destroy(gameObject);
            GameManager.instance.AffectToDestroedCandys(1);

            //add particle sys

        }
        private void Awake()
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}
