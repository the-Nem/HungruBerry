using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HongryBerry
{
    [System.Serializable]
    public class SaveData 
    {

        public int coins;
        public int LifesQuantity;
        public int burgerStatus;
        public int CandyStatus;
        public int CoockeStatus;
        public int MeatStatus;

        public SaveData(CollectValues player)
        {

            coins = player.coins;
            LifesQuantity = player.LifesQuantity;
            burgerStatus = player.burgerStatus;
            CandyStatus = player.CandyStatus;
            CoockeStatus = player.CoockeStatus;
            MeatStatus = player.MeatStatus;
        }
    }
}
