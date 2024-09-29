using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GetSceneDatas : MonoBehaviour
{
    public List<GameObject> Heads;
    public List<GameObject> Dress;
    public GameObject Startup;
    public GameObject StartUst;
    public GameObject Video;

    // Start is called before the first frame update
    void Start()
    {
        Startup.SetActive(false);
        StartUst.SetActive(false);
        Dress[3].SetActive(false);
        SelectHead();
        SelectDress();
        StartCoroutine(HideVideo(5));
    }
    IEnumerator HideVideo(float delay)
    {
        yield return new WaitForSeconds(delay);
        Video.SetActive(false);
    }
    public void SelectHead()
    {
        Heads[StaticData.selectedHead].SetActive(true);
    }
    public void SelectDress()
    {
        Dress[StaticData.selectedDress].SetActive(true);

    }
}
