using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public void quitApplication()
    {
        Application.Quit();
    }

    public void changeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
