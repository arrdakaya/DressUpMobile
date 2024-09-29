using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnHearth : MonoBehaviour
{
    public GameObject objectPrefab;  
    public Transform pointA;         
    public Transform pointB;        
    public float moveSpeed = 5f;     
    public float destroyAfterSeconds = 5f;
    public int clickCount = 0;

    public void SpawnObject()
    {
        Vector3 randomPosition = new Vector3(
            Random.Range(pointA.position.x, pointB.position.x),
            -6,
            0
        );

        GameObject spawnedObject = Instantiate(objectPrefab, randomPosition, Quaternion.identity);

        StartCoroutine(MoveUpAndDestroy(spawnedObject));
        clickCount++;
        if(clickCount == 40)
        {
            SceneManager.LoadScene("WeddingScene");
        }
    }

    // Objeyi yukarý doðru hareket ettirip, ekran dýþýna çýktýðýnda yok eden coroutine
    IEnumerator MoveUpAndDestroy(GameObject spawnedObject)
    {
        float timer = 0f;

        while (timer < destroyAfterSeconds)
        {
            // Zaman geçtikçe yukarý doðru hareket ettir
            spawnedObject.transform.position += Vector3.up * moveSpeed * Time.deltaTime;
            timer += Time.deltaTime;
            yield return null;
        }

        // Belirtilen süre geçtikten sonra objeyi yok et
        Destroy(spawnedObject);
    }
}
