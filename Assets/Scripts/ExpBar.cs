using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpBar : MonoBehaviour
{
    public int value;           // The current exp
    public int min;             // The Exp from the previous level
    public int max;             // The Exp for the next level
    public Slider expBar;
    // Start is called before the first frame update
    void Start()
    {
        expBar = GameObject.GetComponent<Slider>();
        value = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().exp;
        min = 0;
        max = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().expNextLVL;
        expBar.maxValue = max;
        expBar.minValue = min;
        expBar.value = value;
    }

    public void updateBar(int EXP) {
        value = EXP;
        GetComponent<Slider>().value = value;
    }

    public void levelUp(int EXP, int nextLvl) {
        value = EXP;
        min = max;
        max = nextLvl;
        expBar.maxValue = max;
        expBar.minValue = min;
        expBar.value = value;
    }
}
