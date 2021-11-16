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
    }

    public void addExp(int expInc) {
        exp += expInc;
        expBar.GetComponent<ExpBar>().updateBar(exp);
    }

    public void levelUp() {
        //playerHP += HPInt;
        level++;
        calcEXPNextLVL();
        expBar.GetComponent<ExpBar>().levelUp(exp, expNextLVL, level);
    }

    public void calcEXPNextLVL() {
        expNextLVL = 50 * (int)Mathf.Pow(level, 2);
    }
}