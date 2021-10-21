using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealDamage : MonoBehaviour 
{
	public int hit;

	public PlayerHealth playerHealth;

	public void SendDamage (int dam)
	{
	//  playerHealth = GetComponent<PlayerHealth>

		//PlayerHealth playerStats = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
		playerHealth.TakeDamage(dam);
	}
}
