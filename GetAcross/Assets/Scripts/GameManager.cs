using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI gameOverText;

    public TextMeshProUGUI winText;

    public Button restartButton;

    public Button mainButton;

    public AudioSource sadSound;


    public void GameOver()
    {
        sadSound.Play();
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
        mainButton.gameObject.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Win()
    {
        winText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
        mainButton.gameObject.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
