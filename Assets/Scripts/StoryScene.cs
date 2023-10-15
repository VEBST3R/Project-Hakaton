using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "NewStoryScene", menuName = "Data/New Story Scene")]
[System.Serializable]
public class StoryScene : ScriptableObject
{
    public List<Sentence> sentences;
    public Sprite sceneBackground;
    public StoryScene storyScene;

    [System.Serializable]
    public struct Sentence
    {
        public string text;
        public Speaker speaker;
    }
}
