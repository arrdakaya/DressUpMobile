using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetSelectedHead : MonoBehaviour
{
    public List<GameObject> heads = new List<GameObject>();
    private void Start()
    {
        SelectHead();
    }
    private void SetOtherHeadFalse()
    {
        foreach (GameObject head in heads)
        {
            head.SetActive(false);
        }

    }
    public void SelectHead()
    {
    
        SetOtherHeadFalse();
        heads[StaticData.selectedHead].SetActive(true);
    }
}
