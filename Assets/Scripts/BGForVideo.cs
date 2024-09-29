using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGForVideo : MonoBehaviour
{
    public List<Sprite> Background;
    public GameObject BG;
    private void Start()
    {
        SelectBg();
    }
    public void SelectBg()
    {
        BG.GetComponent<SpriteRenderer>().sprite = Background[StaticData.selectedBackground];
    }
}
