using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DressUp : MonoBehaviour
{
    public List<GameObject> DressArray;
    public List<GameObject> HeadArray;
    public GameObject StartupTshirt;
    public GameObject StartupShort;
    public GameObject ArdaDate;


    private void SetOtherDressFalse()
    {
        if (!ArdaDate.activeSelf)
        {
            StartupTshirt.SetActive(true);
        }
        if (StartupTshirt.activeSelf)
        {
            StartupTshirt.SetActive( false);
            StartupShort.SetActive(false);
        }
        foreach (GameObject dress in DressArray)
        {
            dress.SetActive(false);
        }

    }
    public void SelectDress(int dressId)
    {
        SetOtherDressFalse();
        StaticData.selectedDress = dressId;
        DressArray[dressId].SetActive(true);
        
    }
    private void SetOtherHeadFalse()
    {
        foreach (GameObject head in HeadArray)
        {
            head.SetActive(false);
        }

    }
    public void SelectHead(int headId)
    {
        SetOtherHeadFalse();
        StaticData.selectedHead = headId;
        HeadArray[headId].SetActive(true);
    }
}
