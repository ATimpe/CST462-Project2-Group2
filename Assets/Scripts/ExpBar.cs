using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< Updated upstream

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
=======
using UnityEngine.UI;

public class ExpBar : MonoBehaviour
{
    public Slider expSlider;    // The slider for the ExpBar
    public int value;           // The current exp
    public int min;             // The Exp from the previous level
    public int max;             // The Exp for the next level
    // Start is called before the first frame update
    void Start()
    {
        value = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerExp>().exp;
        min = 0;
        max = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerExp>().expNextLVL;
        expSlider.maxValue = max;
        expSlider.minValue = min;
        expSlider.value = value;
>>>>>>> Stashed changes
    }

    public void updateBar(int EXP) {
        value = EXP;
<<<<<<< Updated upstream
        GetComponent<Slider>().value = value;
=======
        Debug.Log("Exp Gained");
        expSlider.value = value;
>>>>>>> Stashed changes
    }

    public void levelUp(int EXP, int nextLvl) {
        value = EXP;
        min = max;
        max = nextLvl;
<<<<<<< Updated upstream
        expBar.maxValue = max;
        expBar.minValue = min;
        expBar.value = value;
    }
}
=======
        expSlider.maxValue = max;
        expSlider.minValue = min;
        expSlider.value = value;
    }
}
>>>>>>> Stashed changes
