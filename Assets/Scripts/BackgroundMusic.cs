using UnityEngine;
using UnityEngine.SceneManagement; // Sahne yönetimi için gerekli

public class BackgroundMusic : MonoBehaviour
{
    private static BackgroundMusic instance = null;
    private AudioSource audioSource;

  
    public AudioClip defaultMusic; 
    public AudioClip weddingMusic; 

    void Awake()
    {
        // Tek bir müzik objesi olmasýný saðlar
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
        // Mevcut sahnenin adýný alýr
        string currentScene = SceneManager.GetActiveScene().name;

        // Eðer sahne "WeddingScene" ise Wedding müziðini çal, deðilse varsayýlan müziði çal
        if (currentScene == "WeddingScene")
        {
            if (audioSource.clip != weddingMusic) // Eðer þimdiki müzik WeddingMusic deðilse deðiþtir
            {
                audioSource.clip = weddingMusic;
                audioSource.Play();
            }
        }
        else
        {
            if (audioSource.clip != defaultMusic) // Eðer þimdiki müzik DefaultMusic deðilse deðiþtir
            {
                audioSource.clip = defaultMusic;
                audioSource.Play();
            }
        }
    }
}
