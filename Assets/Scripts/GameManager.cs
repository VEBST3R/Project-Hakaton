using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SQLite4Unity3d;

public class GameManager : MonoBehaviour
{

    void Start()
    {
        Application.targetFrameRate = 200;

    }
    public void exitGame(){
        Application.Quit();
    }
}
