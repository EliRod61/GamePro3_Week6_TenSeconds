using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    //Plays the scene written down in the Unity Inspector
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
