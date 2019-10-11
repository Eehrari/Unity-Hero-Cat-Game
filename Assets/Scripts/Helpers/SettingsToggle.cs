using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

/// <summary>
/// Toggle the Social Buttons
/// </summary>
public class SettingsToggle : MonoBehaviour
{
    public RectTransform btnFB, btnT, btnG, btnR;
    public float moveFB, moveT, moveG, moveR;
    public float defaultPosY, defaultPosX;
    public float speed;

    bool expanded;

    void Start()
    {
        expanded = false;           // the buttons will be hidden when game begins so we set expanded = false
    }


    public void Toggle()
    {
        if (!expanded)
        {
            // show the buttons
            btnFB.DOAnchorPosY(moveFB, speed, false);
            btnT.DOAnchorPosY(moveT, speed, false);
            btnG.DOAnchorPosY(moveG, speed, false);
            btnR.DOAnchorPosY(moveR, speed, false);
            expanded = true;
        }
        else
        {
            // show the buttons
            btnFB.DOAnchorPosY(defaultPosY, speed, false);
            btnT.DOAnchorPosY(defaultPosY, speed, false);
            btnG.DOAnchorPosY(defaultPosY, speed, false);
            btnR.DOAnchorPosY(defaultPosY, speed, false);
            expanded = false;
        }
    }
}
