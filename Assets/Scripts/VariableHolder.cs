using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableHolder : MonoBehaviour
{
    public int level;
    public int exp;
    public GameObject player;

    void Awake() {
        DontDestroyOnLoad(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateValues() {
        level = player.GetComponent<PlayerExp>().level;
        exp = player.GetComponent<PlayerExp>().exp;
        Debug.Log("Updated Variables");
    }
}
