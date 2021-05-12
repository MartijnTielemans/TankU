using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuFunctions : MonoBehaviour
{
    public void StartGame()
    {
        Debug.Log("ButtonDoTheWorky");
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
