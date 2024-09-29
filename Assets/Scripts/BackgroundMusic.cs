using UnityEngine;
using UnityEngine.SceneManagement; // Sahne y�netimi i�in gerekli

public class BackgroundMusic : MonoBehaviour
{
    private static BackgroundMusic instance = null;
    private AudioSource audioSource;

  
    public AudioClip defaultMusic; 
    public AudioClip weddingMusic; 

    void Awake()
    {
        // Tek bir m�zik objesi olmas�n� sa�lar
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            audioSource = GetComponent<AudioSource>();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        // Mevcut sahnenin ad�n� al�r
        string currentScene = SceneManager.GetActiveScene().name;

        // E�er sahne "WeddingScene" ise Wedding m�zi�ini �al, de�ilse varsay�lan m�zi�i �al
        if (currentScene == "WeddingScene")
        {
            if (audioSource.clip != weddingMusic) // E�er �imdiki m�zik WeddingMusic de�ilse de�i�tir
            {
                audioSource.clip = weddingMusic;
                audioSource.Play();
            }
        }
        else
        {
            if (audioSource.clip != defaultMusic) // E�er �imdiki m�zik DefaultMusic de�ilse de�i�tir
            {
                audioSource.clip = defaultMusic;
                audioSource.Play();
            }
        }
    }
}
