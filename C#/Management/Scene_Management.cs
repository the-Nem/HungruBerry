using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace HongryBerry
{
    public class Scene_Management : MonoBehaviour
    {
        public static Scene_Management instance;
        private void Awake()
        {
            if (instance == null) { instance = this; }
        }


        public void Start()
        {

        }

        public void LoadScene1() { SceneManager.LoadScene(1); }
        public void NextLvlData()
        {
            int acticeScene = SceneManager.GetActiveScene().buildIndex;
            int nextSceneIndex = ++acticeScene;
            if (nextSceneIndex == SceneManager.sceneCountInBuildSettings) { nextSceneIndex = 1; }
            SceneManager.LoadScene(nextSceneIndex);
        }
    }
}