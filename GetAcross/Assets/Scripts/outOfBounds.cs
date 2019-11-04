using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outOfBounds : MonoBehaviour
{
    private float farBound = 27.6f; //Z axis
    private float bottomBound = -23f; // Y axis
    public GameManager gm;
    void Start()
    {
        gm = FindObjectOfType(typeof(GameManager)) as GameManager;
    }

    void Update()
    {
        if(transform.position.z > farBound)
        {
            if(gameObject.tag == "Player")
            {
                gm.GameOver();
            }
            else
            {
                Destroy(gameObject);//Destroys the cow
            }
            
        }
        else if(transform.position.y < bottomBound)
        {
            gm.GameOver();//pops up menu to restart the game
        }
    }
}
