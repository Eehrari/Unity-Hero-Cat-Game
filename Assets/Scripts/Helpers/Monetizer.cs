using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Shows/Hides the ads in the game
/// </summary>
public class Monetizer : MonoBehaviour
{
    public bool timedBanner;            // helps in showing ads for a certain duration
    public float bannerDuration;        // the duration for which you will show the banner ad

    void Start()
    {
        AdsCtrl.instance.ShowBanner();
    }

	void OnDisable()
	{
        if (!timedBanner)
            AdsCtrl.instance.HideBanner();
        else
            AdsCtrl.instance.HideBanner(bannerDuration);
	}
}
