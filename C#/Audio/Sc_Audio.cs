using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace HongryBerry
{
    public class Sc_Audio : MonoBehaviour
    {
        public static Sc_Audio instance;
        private void Awake()
        {
            if (instance == null) { instance = this; }
        }


        public AudioSource BuyCandy;
        public AudioSource DogFart;
        public AudioSource Eating;
        public AudioSource EatPepper;
        public AudioSource GameOver;
        public AudioSource Win;
        public AudioSource ContantLounge;

        [HideInInspector]
        public int FartCount;
        [HideInInspector]
        public int CaloryCount;

        void Update()
        {
            if (FartCount == 4) { PlayDogFart(); FartCount = 0; }
            if (CaloryCount == 3) { PlayEating(); CaloryCount = 0; }
        }



        public void PlayBuyCandy()
        {
            BuyCandy.Play();
        }
        public void PlayDogFart()
        {
            DogFart.Play();
        }
        public void PlayEating()
        {
            Eating.Play();
        }
        public void PlayEatPepper()
        {
            EatPepper.Play();
        }
        public void PlayGameOver()
        {
            GameOver.Play();
        }
        public void PlayWin()
        {
            Win.Play();
        }
        public void PauseMusic()
        {
            ContantLounge.Pause();
        }
        public void UnPauseMusic()
        {
            ContantLounge.UnPause();

        }


    }
}