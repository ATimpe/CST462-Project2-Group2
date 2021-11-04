using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerExp : MonoBehaviour
{
    public int level;
    public int exp;
    public int expNextLVL;
    public GameObject expBar;

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

        if (Input.GetKeyDown("space")) {
            addExp(5);
        }
    }

    public void addExp(int expInc) {
        exp += expInc;
        expBar.GetComponent<ExpBar>().updateBar(exp);
    }

    public void levelUp() {
        //playerHP += HPInt;
        level++;
        calcEXPNextLVL();
        expBar.GetComponent<ExpBar>().levelUp(exp, expNextLVL);
    }

    public void calcEXPNextLVL() {
        expNextLVL = (int)(5000 * (Mathf.Pow(1.11f, level) - 1)) / 11;
    }
}