using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public int attackDamage = 3;

    public GameObject player;

    PlayerHealth playerHealth;

    Rigidbody rb;
    moveForward moveForward;
    BoxCollider boxCollider;



    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<PlayerHealth>();
        rb = GetComponent<Rigidbody>();
        boxCollider = GetComponent<BoxCollider>();
        moveForward = GetComponent<moveForward>();
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Attack();

        if (collision.gameObject.tag == "Player")
        {
            //The cow till be thrown away by hitting the player and will be destroyed within two seconds
            Destroy(gameObject, 2f);

            Vector3 direction = Quaternion.Euler(-20, 0, 0) * -transform.forward;
            rb.AddForce(direction * 20f, ForceMode.Impulse);
            rb.AddTorque(Random.insideUnitSphere * 15f, ForceMode.Impulse);

            moveForward.enabled = false;
            boxCollider.enabled = false;
            
        }
    }

    void Attack()
    {
        //The player takes damage
        if(playerHealth.currentHealth > 0)
        {
            playerHealth.TakeDamage(attackDamage);
        }
    }

}
