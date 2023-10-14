using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    [SerializeField] private Animator MenuAnimator;
    [SerializeField] private Camera camera;
    public void OnSettingsClick(){
        camera.backgroundColor = Color.white;
        MenuAnimator.SetBool("Options", true);
    }
    public void BackSettingsClick(){
        camera.backgroundColor = Color.black;
        MenuAnimator.SetBool("Options", false);
    }
}
