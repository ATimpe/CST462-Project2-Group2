using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Level up formula used from: https://rpg-mo.fandom.com/wiki/Experience_Chart

public class GameManager : MonoBehaviour
{
    public int playerHP;
    public int playerEXP;
    public int playerLVL;
    public int expNextLVL;      // The amount of EXP needed to level up
    public int HPInt;           // The amount of health a player gains per level up
    // Start is called before the first frame update
    void Start()
    {
        calcEXPNextLVL();     // Calculates ho much EXP is needed to go to level 2
    }

    // Update is called once per frame
    void Update()
    {
        if (playerEXP >= expNextLVL) {
            levelUp();
        }
    }

    public void levelUp() {
        playerHP += HPInt;
        playerLVL++;
        calcEXPNextLVL();
    }

    public void calcEXPNextLVL() {
        expNextLVL = (int)(5000 * (Mathf.Pow(1.11f, playerLVL) - 1)) / 11;
    }
}
