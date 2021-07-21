using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

namespace HongryBerry
{
    public class Saver : MonoBehaviour
    {
        public int jsonCandyScore;
        public List<GameObject> JsGameObj;
        public int jsonLifesScore;

        //[Multiline(20)]
        public string data;

        public static Saver instance;
        private void Awake()
        {
            Load();
            if (instance == null) { instance = this; }
        }
        private void Start()
        {


        }
        public void CollectInfo()
        {
            //jsonCandyScore = The_Score.instance.Coin_score_MAIN;
            //jsonLifesScore = The_Score.instance.Lifes_score;
        }
        public void SetInfo()
        {
            //The_Score.instance.Coin_score_MAIN = jsonCandyScore;
            //The_Score.instance.Lifes_score = jsonLifesScore;
        }

        public void Save()
        {
            //CollectInfo();
            //data = JsonUtility.ToJson(this, true);  //prettyPrint, bool, is making nice to see text
            //File.WriteAllText(Application.dataPath + "save.txt", data);// this works
        }
        public void Load()
        {
            //data = File.ReadAllText(Application.dataPath + "save.txt");
            //JsonUtility.FromJsonOverwrite(data, this);
            //SetInfo();
        }

        private void Update()
        {
            //if (Input.GetKeyDown(KeyCode.E)) { jsonCandyScore = 0; jsonLifesScore = 3; Save(); Load();  Debug.Log("save - load"); }
            //Debug.Log("coinsts = " + jsonCandyScore);
            //Debug.Log("jsonLifesScore = " + jsonLifesScore);
        }
        private void OnApplicationQuit()
        {
            Save();
        }
    }
}