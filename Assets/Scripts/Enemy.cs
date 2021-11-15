using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform player;
    public LayerMask whatGround, whatPlayer;
    public float health;

    //Patroling
    public Vector3 walkpoint;
    bool walkPointSet;
    public float walkPointRange;

    //Attacking
    public float timeBetweenAttacks;
    bool alreadyAttacked;
    public GameObject projectile;

    //States
    public float sightRange, attackRange;
    public bool playerInSightRange, playerInAttackRange;
    private void Awake()
    {
        player = GameObject.Find("Player").transform;
        agent = GetComponent<NavMeshAgent>();
    }



    private void Update()
    {
        // Check sight and attack range
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatPlayer);
        playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, whatPlayer);

        // Not in sight or attack range
        if (!playerInSightRange && !playerInAttackRange) patroling();

        // Player in sight range, but not is attack range
        if (playerInSightRange && !playerInAttackRange) chasingPlayer();

        // Player in sight range and attack range
        if (playerInSightRange && playerInAttackRange) attackingPlayer();
    }


    private void patroling()
    {
        if (!walkPointSet) searchWalkPoint();

        if (walkPointSet)
        {
            agent.SetDestination(walkpoint);
        }

        Vector3 distanceToWalkPoint = transform.position - walkpoint;

        // Walkpoint reached
        if(distanceToWalkPoint.magnitude < 1f)
        {
            walkPointSet = false;
        }


    }

    private void searchWalkPoint()
    {
        // Calculate random point in range
        float randomZ = Random.Range(-walkPointRange, walkPointRange);
        float randomX = Random.Range(-walkPointRange, walkPointRange);

        // Find new random point
        walkpoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);

        // Check to make sure its inside the map and on the ground
        if (Physics.Raycast(walkpoint, -transform.up, 2f, whatGround))
        {
            walkPointSet = true;
        }

    }

    private void chasingPlayer()
    {
        agent.SetDestination(player.position);
    }

    private void attackingPlayer()
    {
        // Make sure enemy doesnt move
        agent.SetDestination(transform.position);
        transform.LookAt(player);

        if (!alreadyAttacked)
        {
            //Attack code
            Rigidbody rb = Instantiate(projectile, transform.position, Quaternion.identity).GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * 32f, ForceMode.Impulse);
            rb.AddForce(transform.up * 8f, ForceMode.Impulse);

            alreadyAttacked = true;
            Invoke(nameof(resetAttack), timeBetweenAttacks);
        }
    }

    private void resetAttack()
    {
        alreadyAttacked = false;
    }
   
    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0) Invoke(nameof(DestroyEnemy), .5f);
    }

    private void DestroyEnemy()
    {
        Destroy(gameObject);
    }

    // See attack and sight range
    private void OnDrawGizomsSelected()
    {
        //Gizmos.color = Color.Red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
        //Gizmos.color.Yellow;
        Gizmos.DrawWireSphere(transform.position, sightRange);
    }
}
    
    
    
