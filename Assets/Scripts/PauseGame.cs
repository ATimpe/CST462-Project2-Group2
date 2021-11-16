using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    // Start is called before the first frame update
    public bool Paused = false;
    public GameObject ThePlayer;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (Paused == false)
            {
                Time.timeScale = 0;
                Paused = true;
                ThePlayer.GetComponent<FirstPersonController>().enabled = false;
                Cursor.visible = true;
                SceneManager.LoadScene("Pause Scene");
            }
            else
            {
                ThePlayer.GetComponent<FirstPersonController>().enabled = true;
                Paused = false;
                Time.timeScale = 1;
            }
        }
    }
}
