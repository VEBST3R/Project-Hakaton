using UnityEngine;
using UnityEngine.UI;
public class AudioManager : MonoBehaviour
{
    public AudioSource musicSource; // AudioSource для музики
    public AudioSource soundSource; // AudioSource для звуків

    public Slider musicSlider; // Слайдер для гучності музики
    public Slider soundSlider; // Слайдер для гучності звуків

    private void Start()
    {
        // Ініціалізуємо слайдери з поточими значеннями гучності
        musicSlider.value = musicSource.volume;
        soundSlider.value = soundSource.volume;
    }

    public void SetMusicVolume(float volume)
    {
        // Встановлюємо гучність музики відповідно до значення слайдера
        musicSource.volume = volume;
    }

    public void SetSoundVolume(float volume)
    {
        // Встановлюємо гучність звуків відповідно до значення слайдера
        soundSource.volume = volume;
    }
}