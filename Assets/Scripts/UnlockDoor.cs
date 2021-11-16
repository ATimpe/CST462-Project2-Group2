using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UnlockDoor : Target
{
    // Start is called before the first frame update
    void Start()
    {
        void OnrightMouseDown()
        {
            // this object was clicked - do something
            if (numDestroyed >= 1)
            {
            SceneManager.LoadScene("level_2");
            }

        }
    }

    
}
