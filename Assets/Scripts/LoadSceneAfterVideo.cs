using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneAfterVideo : MonoBehaviour
{
    public List<GameObject> gameObjects = new List<GameObject>();
    public GameObject Arda;
    public GameObject Always;

    public void SetTransformOfSelected(int id)
    {
        foreach (GameObject go in gameObjects)
        {
            go.SetActive(false);
        }
        gameObjects[id].SetActive(true);
        gameObjects[id].transform.position = new Vector3(-0.76f,-0.3f,0);
        Arda.SetActive(true);
        StartCoroutine(HideVideo(3));
    }
    IEnumerator HideVideo(float delay)
    {
        yield return new WaitForSeconds(delay);
        Always.SetActive(true);
    }
}
