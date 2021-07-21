using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HongryBerry
{
    public class CollectValues : MonoBehaviour
    {
        The_Score ts = new The_Score();

        public int coins=0;
        public int LifesQuantity=0;

        public int burgerStatus;
        public int CandyStatus;
        public int CoockeStatus;
        public int MeatStatus;

        public static CollectValues instance;
        private void Awake()
        {
            if (instance == null) { instance = this; }
        }
        private void Start()
        {

            LoadPayerData();
            SetData();
            BornCandies.instance.CheckForFood();

        }
        public void Update()
        {
            //coins = The_Score.instance.Coin_score_MAIN;  /// ?!?!?!?!!??!


            //Debug.Log("coins in saver = " + coins);
            //Debug.Log("coins in game = " + ts.Coin_score_MAIN);



            if (Input.GetKeyDown(KeyCode.S)) 
            {
                GetData();
                SavePlayerData();
                Debug.Log("coins = " + coins);
                //Debug.Log();
                //Debug.Log();
            }
            if (Input.GetKeyDown(KeyCode.L)) 
            { 
                LoadPayerData();
                SetData();
                Debug.Log("coins = " + coins);
            }

            if (Input.GetKeyDown(KeyCode.F))
            {
                The_Score.instance.Coin_score_MAIN = 0;
                The_Score.instance.Lifes_score = 3;
                BornCandies.instance.burgerStatus = 0;
                BornCandies.instance.CandyStatus = 0;
                BornCandies.instance.CoockeStatus = 0;
                BornCandies.instance.MeatStatus = 0;
                SavePlayerData();

            }
        }


        public void SavePlayerData()
        {
            SaverBase.SaveValues(this);
        }

        public void LoadPayerData()
        {
            SaveData data = SaverBase.LoadPlayer();
            coins = data.coins;
            LifesQuantity = data.LifesQuantity;
            burgerStatus = data.burgerStatus;
            CandyStatus = data.CandyStatus;
            CoockeStatus = data.CoockeStatus;
            MeatStatus = data.MeatStatus;
        }

        public void GetData()
        {
            //coins = ts.Coin_score_MAIN;
            coins = The_Score.instance.Coin_score_MAIN;
            LifesQuantity = The_Score.instance.Lifes_score;
            burgerStatus = BornCandies.instance.burgerStatus;
            CandyStatus = BornCandies.instance.CandyStatus;
            CoockeStatus = BornCandies.instance.CoockeStatus;
            MeatStatus = BornCandies.instance.MeatStatus;


        }
        private void SetData()
        {
            The_Score.instance.Coin_score_MAIN = coins;
            The_Score.instance.Lifes_score = LifesQuantity;
            BornCandies.instance.burgerStatus = burgerStatus;
            BornCandies.instance.CandyStatus = CandyStatus;
            BornCandies.instance.CoockeStatus = CoockeStatus;
            BornCandies.instance.MeatStatus = MeatStatus;
        }

        private void OnDestroy() { SavePlayerData(); }
        private void OnApplicationQuit() { SavePlayerData(); }

    }
}
