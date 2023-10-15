using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using SQLite4Unity3d;

public class NameChecker : MonoBehaviour
{
    [SerializeField] private Button StartButton;
    [SerializeField] private TMP_InputField NameField;
    [SerializeField] private Speaker Pers;

    private SQLiteConnection dbConnection;
    private string dbName = "Assets/database/gamebase.db"; // Назва файлу бази даних

    private void CheckBD()
    {
        string dbPath;

        // Визначаємо шлях до бази даних залежно від платформи
        #if UNITY_EDITOR
            // Використовуємо спеціальний шлях для редактора Unity
            dbPath = dbName;
        #elif UNITY_ANDROID
            // Шлях до бази даних на Android
            dbPath = Application.persistentDataPath + "/" + dbName;
        #else
            // Ваш специфічний шлях для інших платформ
            dbPath = Application.dataPath + "/" + dbName;
        #endif

        // Встановлюємо з'єднання з базою даних
        dbConnection = new SQLiteConnection(dbPath, SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create);

        dbConnection.CreateTable<PlayerInfo>(); // Додана таблиця PlayerInfo

        // Ваш код для роботи з базою даних
    }

    private void Start()
    {
        // Додаємо обробник події для TMP полю введення (TMP_InputField)
        NameField.onValueChanged.AddListener(OnNameFieldValueChanged);
        CheckBD();
    }

    private void OnNameFieldValueChanged(string newValue)
    {
        // Перевіряємо, чи TMP поле введення не пусте
        bool isInputFieldNotEmpty = !string.IsNullOrEmpty(newValue);

        // Встановлюємо активність кнопки "Start" відповідно до стану TMP поля введення
        StartButton.interactable = isInputFieldNotEmpty;
    }

    public void OnStartButtonClick()
    {
        // Отримуємо ім'я з TMP InputField
        string playerName = NameField.text;

        // Видаляємо всі попередні записи
        dbConnection.DeleteAll<PlayerInfo>();

        // Додаємо новий запис із ім'ям гравця
        var playerInfo = new PlayerInfo
        {
            PlayerName = playerName,
            Scene1Choise = 0,
            Scene2Choise = 0,
            Scene3Choise = 0
        };
        dbConnection.Insert(playerInfo);
        Pers.newPesonage = playerName;
        // Виконуємо додаткові дії, які вам потрібні після збереження імені
    }
}
