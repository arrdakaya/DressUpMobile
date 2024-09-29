using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectBackground : MonoBehaviour
{
    public List<Sprite> Background;
    public GameObject BG;

    public void SelectBg(int bgID)
    {
        StaticData.selectedBackground = bgID;
        BG.GetComponent<SpriteRenderer>().sprite = Background[bgID];
    }
}
