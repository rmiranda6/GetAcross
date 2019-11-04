using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int startingHealth = 3;

    public int currentHealth;

    public Slider healthSlider;

    public Image damageImage;

    public float flashSpeed = 5f;

    public Color flashColor = new Color(1f, 0f, 0f, 0.1f);

    playerController playerController;

    bool isDead;

    bool damaged;

    public GameManager gm;

    void Start()
    {
        playerController = GetComponent<playerController>();

        currentHealth = startingHealth;

        gm = FindObjectOfType(typeof(GameManager)) as GameManager;
    }

    // Update is called once per frame
    void Update()
    {
        //This shows a red screen for when the player gets damaged
        if(damaged)
        {
            damageImage.color = flashColor;
        }
        else
        {
            damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
        }

        damaged = false;
    }


    public void TakeDamage(int amount)
    {
        //When the player takes damage it will display the players current health bar
        damaged = true;

        currentHealth -= amount;

        healthSlider.value = currentHealth;

        if(currentHealth <= 0 && !isDead)
        {
            Death();//When the player's health reaches zero, the Death method will be called
        }
    }

    void Death()
    {
        //When the player is dead, the pop up game over menu will pop up
        isDead = true;
        playerController.enabled = false;
        gm.GameOver();
    }

}
