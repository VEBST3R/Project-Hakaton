using UnityEngine;
using UnityEngine.UI;
public class AudioManager : MonoBehaviour
{
    public AudioSource musicSource; // AudioSource для музики
    public AudioSource soundSource; // AudioSource для звуків

    public Slider musicSlider; // Слайдер для гучності музики
    public Slider soundSlider; // Слайдер для гучності звуків

    public void SetMusicVolume()
    {
        // Встановлюємо гучність музики відповідно до значення слайдера
        musicSource.volume = musicSlider.value;
    }

    public void SetSoundVolume()
    {
        // Встановлюємо гучність звуків відповідно до значення слайдера
        soundSource.volume = soundSlider.value;
    }
}