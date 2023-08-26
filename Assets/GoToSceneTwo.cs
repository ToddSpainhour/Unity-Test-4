using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoToSceneTwo : MonoBehaviour
{
    public void GoToSceneTwoClickEvent()
    {
        Debug.Log("you clciked the button");
        //Console.WriteLine("do you see this");
        SceneManager.LoadScene("SceneTwo");
    }
}
