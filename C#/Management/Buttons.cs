using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace HongryBerry
{
    public class Buttons : MonoBehaviour
    {

        public static Buttons instance;
        private void Awake()
        {
            if (instance == null) { instance = this; }
        }

        public int StatusRate;
        public GameObject PanelRateGame;
        public GameObject ButtonVideoReward;
        public GameObject CompliteVideoReward;

        public void Load_lvl_1()
        {
           // The_Score.instance.ResetJSON();
            SceneManager.LoadScene(1);
        }

        public void Exit_game()
        {
            GameManager.game_status = false;
            Application.Quit();
        }
        public void LoadNextLvl()
        {
            CollectValues.instance.GetData();
            CollectValues.instance.SavePlayerData();
            //Scene_Management.instance.NextLvlData();
            NextLvlData();
        }

        private static void NextLvlData()
        {
            int acticeScene = SceneManager.GetActiveScene().buildIndex;
            int nextSceneIndex = ++acticeScene;
            if (nextSceneIndex == SceneManager.sceneCountInBuildSettings) { nextSceneIndex = 1; }
            SceneManager.LoadScene(nextSceneIndex);
        }

        public void LinkToInstagram()
        {
            Application.OpenURL("https://www.instagram.com/the_nem.s/");
        }

        public void LinkToPatreon()
        {
            Application.OpenURL("https://www.patreon.com/the_nem_s");
        }

        public void Settings()
        {
            //PauseGame.instance.Pause();
            PauseGame.Pause();

        }
        public void Continue()
        {
            //PauseGame.instance.Resume();
            PauseGame.Resume();
        }

        public void UseButtonReward(bool status)
        {
            ButtonVideoReward.SetActive(status);
            CompliteVideoReward.SetActive(!status);
        }
        public void ShowRatePanel()
        {
            if (StatusRate < 0) { return; }

            else
            {
                PanelRateGame.SetActive(true);
            }
        }
        public void RateUsButton()
        {
            //Application.OpenURL("market://details?id=PackageName");
            Application.OpenURL("market://details?id=com.CompanyName.ProductName");
            StatusRate++;
            PlayerPrefs.SetInt("StatusRate", StatusRate);

        }

        public void BuyBurger()
        {
            if (The_Score.instance.burgerCost > The_Score.instance.Coin_score_MAIN) { return; }
            BornCandies.instance.AddBurgr();
            The_Score.instance.Coin_score_MAIN -= The_Score.instance.burgerCost;


        }

        public void BuyCandy()
        {
            if (The_Score.instance.candyCost > The_Score.instance.Coin_score_MAIN) { return; }
            BornCandies.instance.AddCandy();
            The_Score.instance.Coin_score_MAIN -= The_Score.instance.candyCost;
            Sc_Audio.instance.PlayBuyCandy();

        }
        public void BuyCoocke()
        {
            if (The_Score.instance.coockyCost > The_Score.instance.Coin_score_MAIN) { return; }
            BornCandies.instance.AddCoocke();

            The_Score.instance.Coin_score_MAIN -= The_Score.instance.coockyCost;
            Sc_Audio.instance.PlayBuyCandy();


        }
        public void BuyMeat()
        {
            if (The_Score.instance.meatCost > The_Score.instance.Coin_score_MAIN) { return; }
            BornCandies.instance.AddMeat();

            The_Score.instance.Coin_score_MAIN -= The_Score.instance.meatCost;
            Sc_Audio.instance.PlayBuyCandy();


        }

        public void BuyLife()
        {
            if (The_Score.instance.lifeCost > The_Score.instance.Coin_score_MAIN) { return; }
            if (The_Score.instance.Lifes_score == 3) { return; }
            if (The_Score.instance.Lifes_score == 2) { GameManager.instance.AAA_Lives.transform.GetChild(2).gameObject.SetActive(true); The_Score.instance.Coin_score_MAIN -= The_Score.instance.lifeCost; }
            if (The_Score.instance.Lifes_score == 1) { GameManager.instance.AAA_Lives.transform.GetChild(1).gameObject.SetActive(true); The_Score.instance.Coin_score_MAIN -= The_Score.instance.lifeCost; }
            if (The_Score.instance.Lifes_score == 0) { GameManager.instance.AAA_Lives.transform.GetChild(0).gameObject.SetActive(true); The_Score.instance.Coin_score_MAIN -= The_Score.instance.lifeCost; }
        }

    }
}
