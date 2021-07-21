using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace HongryBerry
{

    public class DogMovement : MonoBehaviour
    {
        private bool rightBool;
        private bool leftBool;
        private float transformPOS = 10f;
        private float max_movement = 8f;
        float xPosss;
        void Update()
        {
            if (rightBool) { MR(); }
            if (leftBool) { ML(); }
            //Debug.Log(rightBool);
            //Debug.Log(leftBool);
        }
        private void MR()
        {
            transform.position += Vector3.right * transformPOS * 2f * Time.deltaTime;
            float X_pos = Mathf.Clamp(transform.position.x, -max_movement, max_movement);
            transform.position = new Vector3(X_pos, transform.position.y, transform.position.z);
        }
        private void ML()
        {
            transform.position -= Vector3.right * transformPOS * 2f * Time.deltaTime;
            float X_pos = Mathf.Clamp(transform.position.x, -max_movement, 0f);
            transform.position = new Vector3(X_pos, transform.position.y, transform.position.z);
        }
        public void ChangeBoolRight(bool rigth)
        {
            rightBool = rigth;
        }
        public void ChangeBoolLeft(bool left)
        {
            leftBool = left;
        }
    }
}
