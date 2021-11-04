using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("level_1");
    }

    public void QuitGame()
    {
        SceneManager.LoadScene("Credits");

        //Application.Quit();
    }

    public void Howtoplay()
    {
        SceneManager.LoadScene("Game Instructions");
    }

    public void ReturnMenu()
    {
        //returns to main menu
        SceneManager.LoadScene("MainMenu");
    }
}
