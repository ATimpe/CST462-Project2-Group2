using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealDamage : MonoBehaviour 
{
    public float damage;
    public GameObject triggeringEnemy;


    public void SendDamage (int dam)
	{
		PlayerHealth playerStats = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
		playerStats.TakeDamage(1);
	}



}
