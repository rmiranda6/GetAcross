using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outOfBounds : MonoBehaviour
{
    private float farBound = 27.6f; //Z axis
    private float bottomBound = -23f; // Y axis
    void Start()
    {
        
    }

    void Update()
    {
        if(transform.position.z > farBound)
        {
            Destroy(gameObject);
        }
        else if(transform.position.y < bottomBound)
        {
            Destroy(gameObject);// Try to make player loose, not destroyed
        }
    }
}
