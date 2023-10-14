using UnityEngine;

[CreateAssetMenu(fileName = "NewStoryScene", menuName = "Data/New Story Scene")]
[System.Serializable]
public class StoryScene : ScriptableObject
{
    public Sprite sceneBackground;
    public StoryScene storyScene;
    // public struct Sentence
    // {
    //     public string text;
    //     // public Speaker speaker;
    // }
}
