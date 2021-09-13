using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using System;
using GoogleMobileAds.Api;


public class AdMob : MonoBehaviour
{
    private BannerView bannerView;
    private InterstitialAd interstitial;
    private RewardedAd rewardedAd;
    public Text totalscore;

    // Start is called before the first frame update
    void Start()
    {
        MobileAds.Initialize(initStatus => { });
        
        RequestBanner();
        showBanner();

        RequestInterstitial();
        
        RequestReward();

        // Called when the ad is closed.
        this.rewardedAd.OnAdClosed += HandleRewardedAdClosed;

    }

    private void RequestBanner()
    {
        #if UNITY_ANDROID
            string adUnitId = "ca-app-pub-3765257123893161/3019783886";
        #elif UNITY_IPHONE        
            //string adUnitId = "ca-app-pub-3940256099942544/2934735716";
        #else
            string adUnitId = "unexpected_platform";
        #endif

        // Create a smart banner at the bottom of the screen.
        bannerView = new BannerView(adUnitId, AdSize.SmartBanner, AdPosition.Bottom);
    }

    private void RequestInterstitial()
    {
        #if UNITY_ANDROID
            string adUnitId = "ca-app-pub-3765257123893161/1841260127";
        #elif UNITY_IPHONE
           // string adUnitId = "ca-app-pub-3940256099942544/4411468910";
        #else
            string adUnitId = "unexpected_platform";
        #endif

        // Initialize an InterstitialAd.
        interstitial = new InterstitialAd(adUnitId);
    }

    private void RequestReward()
    {
        #if UNITY_ANDROID
            string adUnitId = "ca-app-pub-3765257123893161/8023525091";
        #elif UNITY_IPHONE
            //string adUnitId = "ca-app-pub-3940256099942544/1712485313";
        #else
            string adUnitId = "unexpected_platform";
        #endif

        // Initialize an InterstitialAd.
        rewardedAd = new RewardedAd(adUnitId);
    }

    public void showBanner()
    {
        AdRequest request = new AdRequest.Builder().Build();
        bannerView.LoadAd(request);
    }

    public void showInterstitial()
    {
        AdRequest request = new AdRequest.Builder().Build();
        interstitial.LoadAd(request);
        if (interstitial.IsLoaded())
        {
            interstitial.Show();
        }
    }

    public void showReward()
    {
        AdRequest request = new AdRequest.Builder().Build();
        rewardedAd.LoadAd(request);
        if (rewardedAd.IsLoaded())
        {
            rewardedAd.Show();


        }
    }

    public void HandleRewardedAdClosed(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardedAdClosed event received");
        int coins = 0;
        int reward_coins = 25;

        coins = PlayerPrefs.GetInt("TotalCoins", 0);
        PlayerPrefs.SetInt("TotalCoins", coins + reward_coins);

        int tcoins = coins+reward_coins;

        totalscore.text = tcoins.ToString();

        // SceneManager.LoadScene(0);

    }
}
