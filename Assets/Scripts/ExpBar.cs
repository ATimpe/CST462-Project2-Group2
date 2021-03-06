using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpBar : MonoBehaviour
{
    public Slider expSlider;    // The slider for the ExpBar
    public Text lvlTxt;
    public int value;           // The current exp
    public int min;             // The Exp from the previous level
    public int max;             // The Exp for the next level

    // Start is called before the first frame update
    void Start()
    {
        value = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerExp>().exp;
        min = 50 * (int)Mathf.Pow(GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerExp>().level - 1, 2);
        max = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerExp>().expNextLVL;
        expSlider.maxValue = max;
        expSlider.minValue = min;
        expSlider.value = value;
    }

    public void updateBar(int EXP) {
        value = EXP;

        Debug.Log("Exp Gained");
        expSlider.value = value;
    }

    public void levelUp(int EXP, int nextLvl, int lvl) {
        value = EXP;
        min = 50 * (int)Mathf.Pow(lvl - 1, 2);
        Debug.Log(min);
        max = nextLvl;
        lvlTxt.GetComponent<Text>().text = "Level " + lvl;

        expSlider.maxValue = max;
        expSlider.minValue = min;
        Debug.Log(min);
        expSlider.value = value;
    }
}

