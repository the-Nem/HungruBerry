using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace HongryBerry
{
    public class Player : MonoBehaviour
    {
        The_Score ts = new The_Score();
        public Text Text_LVL;
        public Text Text_HP;
        public Text Text_coin;

        public int Lvl = 3;
        public int health = 40;
        public int coin;

        private void Start()
        {
            coin = ts.Coin_score_MAIN;
        }
        private void Update()
        {
            Text_LVL.text = Lvl.ToString();
            Text_HP.text = health.ToString();
            Text_coin.text = coin.ToString();
        }

        public void SavePlayerDate()
        {
            SaveManager.SaveValues(this);
        }

        public void LoadPayerData()
        {
            PlayerData data = SaveManager.LoadPlayer();
            Lvl = data.Lvl;
            health = data.health;
        }
        public void IncreaseLVL()
        {
            Lvl++;
        }
        public void IncreaseHP()
        {
            health++;
        }
        public void IncreaseCoins()
        {
            ts.Coin_score_MAIN++;
        }
    }
}
