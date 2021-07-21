using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace HongryBerry
{
    public class PlayerCollider : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            InterfaceColliders ic = collision.GetComponent<InterfaceColliders>();
            if (ic != null) { ic.I_CandyAction(); }
        }
        private void Awake()
        {
            //DontDestroyOnLoad(gameObject);
        }
    }
}
