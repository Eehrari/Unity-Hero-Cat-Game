using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Provides functionality to the Social buttons like Facebook Like, Twitter Follow, Google Plus & Ratings
/// </summary>
public class SettingsCtrl : MonoBehaviour
{
    public string facebookURL, twitterURL, googlePlusURL, ratingURL;

    public void FacebookLike()
    {
        Application.OpenURL(facebookURL);
    }

    public void TwitterFollow()
    {
        Application.OpenURL(twitterURL);
    }

    public void GooglePlus()
    {
        Application.OpenURL(googlePlusURL);
    }

    public void Rating()
    {
        Application.OpenURL(ratingURL);
    }

}
