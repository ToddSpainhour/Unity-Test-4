using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToSceneOne : MonoBehaviour
{
    public void GoToSceneOneCLickEvent()
    {
        Debug.Log("you clicked in Scene 2's button");
        SceneManager.LoadScene("SampleScene");
    }
}
