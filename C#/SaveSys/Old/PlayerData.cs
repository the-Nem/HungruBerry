using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HongryBerry
{
[System.Serializable]
    public class PlayerData 
    {
        public int Lvl;
        public int health;
        public int coin;

        public PlayerData(Player player)
        {
            Lvl = player.Lvl;
            health = player.health;
            coin = player.coin;
        }
    }
}
