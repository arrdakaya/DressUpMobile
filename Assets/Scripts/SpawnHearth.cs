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

    // Objeyi yukar� do�ru hareket ettirip, ekran d���na ��kt���nda yok eden coroutine
    IEnumerator MoveUpAndDestroy(GameObject spawnedObject)
    {
        float timer = 0f;

        while (timer < destroyAfterSeconds)
        {
            // Zaman ge�tik�e yukar� do�ru hareket ettir
            spawnedObject.transform.position += Vector3.up * moveSpeed * Time.deltaTime;
            timer += Time.deltaTime;
            yield return null;
        }

        // Belirtilen s�re ge�tikten sonra objeyi yok et
        Destroy(spawnedObject);
    }
}
