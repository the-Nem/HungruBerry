using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HongryBerry
{
    public class BlackCollider : MonoBehaviour
    {

        private void OnTriggerEnter2D(Collider2D collision)
        {
            Destroy(collision.gameObject);

            GameManager.instance.AffectToDestroedCandys(1);
            //Debug.Log("trigger working");
        }
    }
}
