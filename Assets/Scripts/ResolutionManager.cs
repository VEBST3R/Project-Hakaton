using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResolutionChanger : MonoBehaviour
{
    private int currentResolutionIndex = 0; // Поточний індекс роздільної здатності
    private ScreenResolution[] resolutions;  // Масив роздільних здатностей
    public TMP_Text resolutionText;          // Посилання на TextMeshPro Text

    private void Start()
    {
        // Ініціалізуємо масив роздільних здатностей
        resolutions = new ScreenResolution[]
        {
            new ScreenResolution("Full HD", 1920, 1080),
            new ScreenResolution("HD", 1280, 720),
            new ScreenResolution("4K", 3840, 2160),
            new ScreenResolution("720p", 1280, 720),
            new ScreenResolution("1080p", 1920, 1080)
        };

        // Встановлюємо початкову роздільну здатність
        SetResolution(currentResolutionIndex);
    }

    public void IncreaseResolution()
    {
        // Збільшуємо індекс роздільної здатності
        currentResolutionIndex++;

        // Перевіряємо, чи не виходимо за межі масиву роздільних здатностей
        if (currentResolutionIndex >= resolutions.Length)
        {
            currentResolutionIndex = resolutions.Length - 1;
        }

        // Встановлюємо нову роздільну здатність
        SetResolution(currentResolutionIndex);
    }

    public void DecreaseResolution()
    {
        // Зменшуємо індекс роздільної здатності
        currentResolutionIndex--;

        // Перевіряємо, чи не виходимо за межі масиву роздільних здатностей
        if (currentResolutionIndex < 0)
        {
            currentResolutionIndex = 0;
        }

        // Встановлюємо нову роздільну здатність
        SetResolution(currentResolutionIndex);
    }

    private void SetResolution(int index)
    {
        // Встановлюємо роздільну здатність за допомогою Screen.SetResolution
        Screen.SetResolution(resolutions[index].width, resolutions[index].height, Screen.fullScreen);

        // Оновлюємо значення TextMeshPro Text
        resolutionText.text = $"{resolutions[index].width}x{resolutions[index].height}";
    }
}

[System.Serializable]
public struct ScreenResolution
{
    public string name; // Назва роздільної здатності
    public int width;   // Ширина
    public int height;  // Висота

    public ScreenResolution(string name, int width, int height)
    {
        this.name = name;
        this.width = width;
        this.height = height;
    }
}
