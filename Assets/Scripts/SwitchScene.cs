using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchScene : MonoBehaviour {

    public void Button_Click(string scene)
    {
        //changes the scene from MainMenu to GameRound
        UnityEngine.SceneManagement.SceneManager.LoadScene(scene);
    }/*
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }*/
    /*
    public UnityEngine.UI.Image BlueSky1;
    public UnityEngine.UI.Image BlueSky;
    public UnityEngine.UI.Button theButton;
    public void ChangeBackground()
    {
        if (theButton.gameObject)
        {
            theButton.image = BlueSky1;

        }
     else
        {
            theButton.image = BlueSky;
        }
     }*/
}