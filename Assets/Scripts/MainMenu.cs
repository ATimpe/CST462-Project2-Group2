using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenuUI;
    public GameObject howToPlayUI;

    public void StartGame()
    {
        SceneManager.LoadScene("level_1");
    }

    public void QuitGame()
    {
        SceneManager.LoadScene("Credits");

        //Application.Quit();
    }

    public void HowToPlay()
    {
        //SceneManager.LoadScene("Game Instructions");

        howToPlayUI.SetActive(true);
        mainMenuUI.SetActive(false);
    }

    public void ReturnMenu()
    {
        //returns to main menu
        //SceneManager.LoadScene("MainMenu");

        howToPlayUI.SetActive(false);
        mainMenuUI.SetActive(true);
    }
}
