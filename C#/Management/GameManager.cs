using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


namespace HongryBerry
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance;
        private void Awake()
        {
            if (instance == null) { instance = this; }
        }

        public static bool game_status = false;
        public bool boolGameOverPanel = false;
        public bool boolPanel_Win_NextLevel = false;

        public GameObject AAA_Lives;
        public Text Panel_text;
        public GameObject Panel_GameOver;
        public GameObject Panel_Win_NextLevel;
        public GameObject Panel_Score;
        public GameObject Panel_Store;
        public GameObject PanelControls;

        public int quantityDestroedCandys = 0;
        public int quantityEatedCandys = 0;

        public int Summ;
        public int maxCandyQuantityInLvl = 6;

        public bool boolShowWinPanel = true;
        public bool boolShowStore = true;
        private bool boolMaxCandy = false;



        void Start()
        {
            game_status = true; //___________________________________________________
        }

        void Update()
        {



            InGameLifeCount();
            Panel_text.text = The_Score.instance.Coin_score_MAIN.ToString();
            Summ = quantityEatedCandys + quantityDestroedCandys;

            if (The_Score.instance.Lifes_score == 0)
            {
                Sc_Audio.instance.PlayGameOver();
                Panel_GameOver.SetActive(true);
                game_status = false;
               // The_Score.instance.ResetJSON();
                StatusPanelControls(false);
                //Debug.Log("game_status false becouse life");
            }
            if (Summ == maxCandyQuantityInLvl && boolMaxCandy == false)
            {
                Sc_Audio.instance.PlayWin();
                game_status = false;

                StatusPanelControls(false);
                StatusWinPanel(true);

                //Debug.Log("game_status =  no more candy");
                quantityDestroedCandys = 0;
                boolMaxCandy = true;
                CollectValues.instance.GetData();
                CollectValues.instance.SavePlayerData();
            }
        }

        public void InGameLifeCount()
        {
            if (The_Score.instance.Lifes_score == 2) { AAA_Lives.transform.GetChild(2).gameObject.SetActive(false); }
            if (The_Score.instance.Lifes_score == 1) { AAA_Lives.transform.GetChild(1).gameObject.SetActive(false); }
            if (The_Score.instance.Lifes_score == 0) { AAA_Lives.transform.GetChild(0).gameObject.SetActive(false); }
        }
        public void AffectToEatedCandys(int candy) { quantityEatedCandys += candy; }
        public void AffectToDestroedCandys(int candy) { quantityDestroedCandys += candy; }
        public void StatusShowPanel(bool on_off) { Panel_Win_NextLevel.SetActive(on_off); }
        public void StatusPanelStore(bool on_off) { Panel_Store.SetActive(on_off); }
        public void StatusWinPanel(bool on_off) { Panel_Win_NextLevel.SetActive(on_off); }
        public void StatusPanelControls(bool on_off) { PanelControls.SetActive(on_off); }


    }
}
