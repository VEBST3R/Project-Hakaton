using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    [SerializeField] private Animator MenuAnimator;
    [SerializeField] private new Camera camera;
    public void OnSettingsClick(){
        camera.backgroundColor = Color.white;
        MenuAnimator.SetBool("Options", true);
    }
    public void BackSettingsClick(){
        camera.backgroundColor = Color.black;
        MenuAnimator.SetBool("Options", false);
    }
    public void OnAuthorsClick(){
        camera.backgroundColor = Color.white;
        MenuAnimator.SetBool("Authors", true);
    }
    public void BackAuthorsClick(){
        camera.backgroundColor = Color.black;
        MenuAnimator.SetBool("Authors", false);
    }
    public void OnNewGameClick(){
        camera.backgroundColor = Color.white;
        MenuAnimator.SetBool("NewGame", true);
    }
    public void BackNewGameClick(){
        camera.backgroundColor = Color.black;
        MenuAnimator.SetBool("NewGame", false);
    }
    public void OnStartGameClick(){
        camera.backgroundColor = Color.black;
        MenuAnimator.SetBool("Start", true);
    }
}
