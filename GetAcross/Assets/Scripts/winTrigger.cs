using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class winTrigger : MonoBehaviour
{
    public TextMeshProUGUI winText;
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            winText.enabled = true;
        }
    }
}
