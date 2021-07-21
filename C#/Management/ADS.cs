
using UnityEngine;
using UnityEngine.Advertisements;

namespace HongryBerry
{
    public class ADS : MonoBehaviour, IUnityAdsListener
    {
        private string FujionPlayStoreID = "4201321";
        private string FujionAppleStoreID = "4201320";
        private string Interstitial_Android = "Interstitial_Android";
        private string Interstitial_iOS = "Interstitial_iOS";
        private string Rewarded_Android = "Rewarded_Android";
        private string Rewarded_iOS = "Rewarded_iOS";



        public bool isTargetPlayStore;  //CHANGE this manually
        public bool isTestAd;           //CHANGE this manually


        void Start()
        {
            isTargetPlayStore = true;   //if platform is android - else false
            //isTestAd = true;            //if platform is android - else false

            Advertisement.AddListener(this);
            InitializeAdvertisment();
        }

        //void Update()
        //{
        //    if (Input.GetKeyDown(KeyCode.I)) { PlayInterstitial_Android(); }
        //    if (Input.GetKeyDown(KeyCode.R)) { PlayRewarded_Android(); }
        //}
        private void InitializeAdvertisment()
        {
            if (isTargetPlayStore) { Advertisement.Initialize(FujionPlayStoreID, isTestAd); return; }
            Advertisement.Initialize(FujionAppleStoreID, isTestAd);
        }
        public void PlayInterstitial_Android()
        {
            if (!Advertisement.IsReady(Interstitial_Android)) { return; }
            Advertisement.Show(Interstitial_Android);
        }

        public void PlayInterstitial_iOS()
        {
            if (!Advertisement.IsReady(Interstitial_iOS)) { return; }
            Advertisement.Show(Interstitial_iOS);
        }
        public void PlayRewarded_Android()
        {
            if (!Advertisement.IsReady(Rewarded_Android)) { return; }
            Advertisement.Show(Rewarded_Android);
            //AudioManagment.instance.PauseMusic();
        }
        public void PlayRewarded_iOS()
        {
            if (!Advertisement.IsReady(Rewarded_iOS)) { return; }
            Advertisement.Show(Rewarded_iOS);
        }
        public void OnUnityAdsReady(string placementId)
        {

        }

        public void OnUnityAdsDidError(string message)
        {
            //error panel
        }

        public void OnUnityAdsDidStart(string placementId)
        {
            Sc_Audio.instance.PauseMusic();
            //pause music
        }

        public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
        {
            switch (showResult)
            {
                case ShowResult.Failed:
                    break;
                case ShowResult.Skipped:
                    break;
                case ShowResult.Finished:
                    if (placementId == Interstitial_Android) { }
                    if (placementId == Rewarded_Android)
                    {
                        Buttons.instance.UseButtonReward(false);
                        The_Score.instance.DoubleCoinsReward();
                        Sc_Audio.instance.UnPauseMusic();

                        //hide panel
                        //show panel
                        //increase coins
                        //unpause music
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
