using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    Rigidbody rb;
    moveForward moveForward;
    BoxCollider boxCollider;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        boxCollider = GetComponent<BoxCollider>();
        moveForward = GetComponent<moveForward>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {

            Destroy(gameObject, 2f);

            Vector3 direction = Quaternion.Euler(-20, 0, 0) * -transform.forward;
            rb.AddForce(direction * 20f, ForceMode.Impulse);
            rb.AddTorque(Random.insideUnitSphere * 15f, ForceMode.Impulse);

            moveForward.enabled = false;
            boxCollider.enabled = false;

            Destroy(other.gameObject);
        }

    }
}

