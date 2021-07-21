using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HongryBerry
{
    public class GiveMeCandy : MonoBehaviour
    {
        public float candyFallSpeed = 0.5f;
        private float random_pos_spawnX;
        public float Timer = 0.35f;
        private int CandyFallCount = 0;

        void Start()
        {
        
        }


        void Update()
        {
            if (GameManager.game_status == false) { return; }
            Timer -= Time.deltaTime;
            if (Timer <= 0)
            {
                SpawnCandy();
                Timer = 2f;
            }
        }
        private void SpawnCandy()
        {
            BornCandies.instance.RandomCandy = Random.Range(0, BornCandies.instance.Feed.Count);
            random_pos_spawnX = Random.Range(-7f, 7f);
            float posSpawnY = 11f;
            Vector2 random_pos_spawn = new Vector2(random_pos_spawnX, posSpawnY);
            Instantiate(BornCandies.instance.Feed[BornCandies.instance.RandomCandy], random_pos_spawn * candyFallSpeed, Quaternion.identity);
            ++CandyFallCount;
        }
    }
}
