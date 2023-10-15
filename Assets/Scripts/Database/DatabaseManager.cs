using UnityEngine;
using SQLite4Unity3d;

public class DatabaseManager : MonoBehaviour
{
    private SQLiteConnection dbConnection;
    private string dbName = "database/gamebase.db"; // Назва файлу бази даних

    private void Awake()
    {
        string dbPath;

        // Визначаємо шлях до бази даних залежно від платформи
        #if UNITY_EDITOR
            dbPath = dbName;
        #elif UNITY_ANDROID
            dbPath = Application.persistentDataPath + "/" + dbName;
        #else
            dbPath = Application.dataPath + "/" + dbName;
        #endif

        // Встановлюємо з'єднання з базою даних
        dbConnection = new SQLiteConnection(dbPath, SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create);

        dbConnection.CreateTable<PlayerInfo>(); // Додана таблиця PlayerInfo

        // Ваш код для роботи з базою даних
    }

    private void OnDestroy()
    {
        // Закрити з'єднання з базою даних при завершенні гри
        if (dbConnection != null)
        {
            dbConnection.Close();
        }
    }
}

// Клас для таблиці PlayerInfo
[Table("PlayerInfo")]
public class PlayerInfo
{
    [PrimaryKey, AutoIncrement]
    public int ID { get; set; }
    public string PlayerName { get; set; }
    public int Scene1Choise { get; set; }
    public int Scene2Choise { get; set; }
    public int Scene3Choise { get; set; }
}