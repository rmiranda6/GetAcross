using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class winTrigger : MonoBehaviour
{
    public GameManager gm;
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            gm.Win();
        }
    }
}
