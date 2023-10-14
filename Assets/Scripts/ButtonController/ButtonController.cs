using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class ChangeTextColorAndOutlineOnHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public TextMeshProUGUI textMeshProText; // Посилання на компонент TMP Text
    public Color hoverTextColor = Color.white; // Колір тексту при наведенні курсора
    public Color hoverOutlineColor = Color.black; // Колір обводки при наведенні курсора

    private Color originalTextColor; // Зберігає початковий колір тексту
    private Color originalOutlineColor; // Зберігає початковий колір обводки

    private void Start()
    {
        // Зберігаємо початковий колір тексту та обводки
        originalTextColor = textMeshProText.color;
        originalOutlineColor = textMeshProText.outlineColor;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // Змінюємо колір тексту та обводки при наведенні курсора
        textMeshProText.color = hoverTextColor;
        textMeshProText.outlineColor = hoverOutlineColor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // Повертаємо початковий колір тексту та обводки при відведенні курсора
        textMeshProText.color = originalTextColor;
        textMeshProText.outlineColor = originalOutlineColor;
    }
}