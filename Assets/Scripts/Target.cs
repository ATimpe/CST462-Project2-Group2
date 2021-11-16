using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 50f;

    public GameObject player;
    public PlayerExp playerExp;

    public int numDestroyed;

    private void Start()
    {
        playerExp = player.GetComponent<PlayerExp>();
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            numDestroyed++;
            Die();
        }
    }

    void Die()
    {
        playerExp.addExp(50);
        Destroy(gameObject);
    }

}
