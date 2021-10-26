using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int level;
    public int exp;
    public int expNextLVL;

    // Start is called before the first frame update
    void Start()
    {
        calcEXPNextLVL();
    }

    // Update is called once per frame
    void Update()
    {
        if (exp >= expNextLVL) {
            levelUp();
        }
    }

    public void levelUp() {
        //playerHP += HPInt;
        level++;
        calcEXPNextLVL();
    }

    public void calcEXPNextLVL() {
        expNextLVL = (int)(5000 * (Mathf.Pow(1.11f, level) - 1)) / 11;
    }
}
