using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// updates the DataCtrl so that it provides the most updated data
/// </summary>
public class RefreshData : MonoBehaviour
{
    void Start()
    {
        DataCtrl.instance.RefreshData();
    }
}
