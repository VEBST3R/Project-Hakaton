using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public StoryScene currentScene;
    public BottomBarController bottomBar;
    public BackgroundController backgroundController;

    void Start()
    {
        bottomBar.PlayScene(currentScene);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            if (bottomBar.IsCompleted())
            {
                if (bottomBar.IsLastSentence())
                {
                    if(bottomBar.sentenceIndex)
                    bottomBar.PlayScene(currentScene);
                    backgroundController.SwitchImage(currentScene.sceneBackground);
                }
                else
                {
                    bottomBar.PlayNextSentence();
                }
            }
        }
    }
}
