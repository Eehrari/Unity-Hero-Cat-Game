using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Shows the loading screen
/// </summary>
public class LoadingCtrl : MonoBehaviour
{
    public GameObject panelLoading;         // shows when the level is loading
    public static LoadingCtrl instance;     // the static instance of this class

    void Start()
    {
        if (instance == null)
            instance = this;
    }

    public void ShowLoading()
    {
        panelLoading.SetActive(true);
    }
}
