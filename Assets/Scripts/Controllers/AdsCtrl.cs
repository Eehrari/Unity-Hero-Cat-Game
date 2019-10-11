using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using System;

/// <summary>
/// Handles Ads in the game
/// </summary>
public class AdsCtrl : MonoBehaviour
{
    public static AdsCtrl instance = null;

    // AdMob Test Ad ID's can be found in sample code, at the url below
    // https://developers.google.com/admob/unity/start
    public string Android_Admob_Banner_ID = "ca-app-pub-3940256099942544/6300978111";      // ca-app-pub-3940256099942544/6300978111
    public string Android_Admob_Interstitial_ID = "ca-app-pub-3940256099942544/1033173712";


    public bool testMode;               // to enable/disable test ads
    public bool showBanner;             // to toggle banner ads
    public bool showInterstitial;       // to toggle interstitial ads
    BannerView bannerView;              // container for the banner ad
    InterstitialAd interstitial;
    AdRequest request;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void RequestBanner()
    {
        // Create a 320x50 banner at the top of the screen
        if(testMode)
            bannerView = new BannerView(Android_Admob_Banner_ID, AdSize.Banner, AdPosition.Top);
        else
        {
            // code for live ad
        }

        // Create an empty ad request
        AdRequest request = new AdRequest.Builder().Build();

        // Load the banner with the request
        bannerView.LoadAd(request);

        HideBanner();
    }

    public void ShowBanner()
    {
        if(showBanner)
            bannerView.Show();
    }

    public void HideBanner()
    {
        if(showBanner)
            bannerView.Hide();
    }

    public void HideBanner(float duration)
    {
        StartCoroutine("HideBannerRoutune", duration);
    }

    IEnumerator HideBannerRoutune(float duration)
    {
        yield return new WaitForSeconds(duration);
        bannerView.Hide();
    }

    void RequestInterstitial()
    {
        // Intialize an interstitial ad
        if(testMode)
            interstitial = new InterstitialAd(Android_Admob_Interstitial_ID);
        else
        {
            // code for live ad
        }

        // Create an empty request
        request = new AdRequest.Builder().Build();

        // Load the Interstitial with the request
        interstitial.LoadAd(request);

             interstitial.OnAdClosed += HandleOnAdClosed;
    }

    public void HandleOnAdClosed(object sender, EventArgs args)
    {
        interstitial.Destroy();
        RequestInterstitial();
    }

    public void ShowInterstitial()
    {
        if(showInterstitial)
        {
            if (interstitial.IsLoaded())
            {
                interstitial.Show();
            }
        }
    }

	void OnEnable()
	{
        if (showBanner)
        {
            RequestBanner();
        }

        if (showInterstitial)
        {
            RequestInterstitial();
        }
	}

	void OnDisable()
	{
        if(showBanner)
            bannerView.Destroy();

        if(showInterstitial)
            interstitial.Destroy();
	}
}
