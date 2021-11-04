using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausedMenu : MonoBehaviour
{
    public void StartGame()
    {
        Cursor.visible = true;
    }
    
    // Start is called before the first frame update
    public void ReturntoMenu()

    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        SceneManager.LoadScene("Credits");
        //Application.Quit();
    }


}
