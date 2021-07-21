using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace HongryBerry
{
    public class The_Score : MonoBehaviour
    {


        public static The_Score instance;
        private void Awake()
        {
            if (instance == null) { instance = this; }

        }


        private int realCoin = 0;

        public int Coin_score_MAIN
        {
            get { return realCoin; }
            set
            {
                //if (value>800) { GameManager.gameStatus = false; return; }
                //else { realCoin = value; }

                realCoin = value;
            }
        }


        public int Lifes_score = 3;


        public int burgerCost = 60;
        public int candyCost = 80;
        public int coockyCost = 80;
        public int meatCost = 100;
        public int lifeCost = 100;




        void Start()
        {



        }

        void Update()
        {
            //if (Input.GetKeyDown(KeyCode.C)) { Candy_score += 9999;  Lifes_score =3;  Saver.instance.Save(); Debug.Log("cheat working"); }

            if (Input.GetKeyDown(KeyCode.P)) { CandyCalculation(100); }

        }
        public void LooseLive(int life) { Lifes_score += life; }    
        public void CandyCalculation(int candy) { Coin_score_MAIN += candy; } 
        public void DoubleCoinsReward()
        {
            Coin_score_MAIN = Coin_score_MAIN * 2;

        }

        //public void BuyBurger()
        //{
        //    if (burgerCost > Coin_score_MAIN) { return; }
        //    //Debug.Log("working");
        //    //Spawn3.instance.AddBurgr();
        //    Coin_score_MAIN -= burgerCost;
            

        //}

        //public void BuyCandy()
        //{
        //    if (candyCost > Coin_score_MAIN) { return; }
        //    //Spawn3.instance.AddCandy();
        //    Coin_score_MAIN -= candyCost;
        //    Sc_Audio.instance.PlayBuyCandy();

        //}
        //public void BuyCoocke()
        //{
        //    if (coockyCost > Coin_score_MAIN) { return; }
        //    //Spawn3.instance.AddCoocke();
        //    Coin_score_MAIN -= coockyCost;
        //    Sc_Audio.instance.PlayBuyCandy();


        //}
        //public void BuyMeat()
        //{
        //    if (meatCost > Coin_score_MAIN) { return; }
        //    //Spawn3.instance.AddMeat();
        //    Coin_score_MAIN -= meatCost;
        //    Sc_Audio.instance.PlayBuyCandy();


        //}

        //public void BuyLife()
        //{
        //    if (lifeCost > Coin_score_MAIN) { return; }
        //    if (Lifes_score == 3) { return; }
        //    if (Lifes_score == 2) { GameManager.instance.AAA_Lives.transform.GetChild(2).gameObject.SetActive(true); Coin_score_MAIN -= lifeCost; }
        //    if (Lifes_score == 1) { GameManager.instance.AAA_Lives.transform.GetChild(1).gameObject.SetActive(true); Coin_score_MAIN -= lifeCost; }
        //    if (Lifes_score == 0) { GameManager.instance.AAA_Lives.transform.GetChild(0).gameObject.SetActive(true); Coin_score_MAIN -= lifeCost; }
        //}
    }
}
