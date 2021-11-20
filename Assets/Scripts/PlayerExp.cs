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
    public GameObject variableHolder;

    public int targetsDestroyed = 0;

    // Start is called before the first frame update
    void Start()
    {
        variableHolder = GameObject.FindGameObjectsWithTag("VariableHolder")[0];
        level = variableHolder.GetComponent<VariableHolder>().level;
        exp = variableHolder.GetComponent<VariableHolder>().exp;
        calcEXPNextLVL();
        expBar.GetComponent<ExpBar>().levelUp(exp, expNextLVL, level);
        expBar.GetComponent<ExpBar>().updateBar(exp);
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
        updateVariableHolder();
    }

    public void levelUp() {
        //playerHP += HPInt;
        level++;
        calcEXPNextLVL();
        expBar.GetComponent<ExpBar>().levelUp(exp, expNextLVL, level);
        updateVariableHolder();
        gameObject.GetComponent<PlayerHealth>().health += 10;
    }

    public void calcEXPNextLVL() {
        expNextLVL = 50 * (int)Mathf.Pow(level, 2);
    }

    public void updateVariableHolder() {
        variableHolder.GetComponent<VariableHolder>().updateValues();
    }
}