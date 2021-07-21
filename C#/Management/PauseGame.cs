using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HongryBerry
{
    public class PauseGame : MonoBehaviour
    {

        public bool GameIsPaused = false;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        public static void Resume()
        {
            Time.timeScale = 1f;
        }
        public static void Pause()
        {
            Time.timeScale = 0f;
        }
    }
}
