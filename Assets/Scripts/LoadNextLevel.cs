using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextLevel : MonoBehaviour
{
    public GameObject levelGateLight;
    public LightController lightController;

    // Start is called before the first frame update
    void Start()
    {
        lightController = levelGateLight.GetComponent<LightController>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Player") && lightController.nextLevelUnlocked)
        {
            GameObject.FindGameObjectsWithTag("VariableHolder")[0].GetComponent<VariableHolder>().level = GameObject.FindGameObjectsWithTag("Player")[0].GetComponent<PlayerExp>().level;
            GameObject.FindGameObjectsWithTag("VariableHolder")[0].GetComponent<VariableHolder>().exp = GameObject.FindGameObjectsWithTag("Player")[0].GetComponent<PlayerExp>().exp;
            SceneManager.LoadScene("level_2");
        }
    }
}
