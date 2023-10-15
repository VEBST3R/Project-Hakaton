using UnityEngine;

public class Audio_Manager : MonoBehaviour
{
    private static Audio_Manager instance;

    public AudioClip defaultMusic; // Музичний файл за замовчуванням
    public AudioClip scene1Music; // Музичний файл для сцени 1
    public AudioClip scene2Music; // Музичний файл для сцени 2 (змініть на потрібні файли)

    private AudioSource audioSource;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);

            audioSource = GetComponent<AudioSource>();

            // Встановлення музики за замовчуванням
            if (defaultMusic != null)
            {
                audioSource.clip = defaultMusic;
                audioSource.Play();
            }
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void ChangeMusicForScene(string sceneName)
    {
        // Визначення, який музичний файл встановити для сцени
        if (sceneName == "Game")
        {
            if (scene1Music != null)
            {
                audioSource.clip = scene1Music;
                audioSource.Play();
            }
        }
        else if (sceneName == "MainMenu")
        {
            if (scene2Music != null)
            {
                audioSource.clip = scene2Music;
                audioSource.Play();
            }
        }
        // Додайте інші перевірки для інших сцен, якщо потрібно
    }
}
