using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class winTrigger : MonoBehaviour
{
    public GameManager gm;

    public playerController player;

    public AudioSource winMusic;
    public AudioSource gameMusic;
    public AudioSource cheering;
    public AudioSource horn;

    void Start()
    {
        gm = FindObjectOfType(typeof(GameManager)) as GameManager;
        player = FindObjectOfType(typeof(playerController)) as playerController;
    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            gameMusic.Pause();
            cheering.Play();
            horn.Play(220500);//its going to play the party horn after 5 seconds
            winMusic.Play();
            gm.Win();
            player.enabled = false;
        }
    }
}
