using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

/*
 * Sam Ferstein
 * GameManager.cs
 * Assignment 5
 * This is the game manager file to control the game.
 */

public class GameManager : MonoBehaviour
{
    public GameObject titleScreen;
    public GameObject difficultyScreen;
    public GameObject truck;
    public GameObject car;
    public GameObject police;
    public GameObject gOverScreen;
    public GameObject gWinScreen;
    public TextMeshProUGUI timerText;
    public GameObject player;
    public bool isGameActive;
    public bool isGameLost = false;
    private float timer = 60;
    

    // Start is called before the first frame update
    void Start()
    {
        timerText.gameObject.SetActive(false);
    }

    public void difficultySelect()
    {
        titleScreen.gameObject.SetActive(false);
        difficultyScreen.gameObject.SetActive(true);
        truck.gameObject.SetActive(true);
        car.gameObject.SetActive(true);
        police.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameActive == true)
        {
            timer -= Time.deltaTime;
            timerText.text = "Time: " + timer.ToString("f0");
            if (timer <= 0 && isGameLost == false)
            {
                gameWon();
            }
        }
    }

    public void startGame()
    {
        isGameActive = true;
        isGameLost = false;
        player.gameObject.SetActive(true);
        timerText.gameObject.SetActive(true);
        difficultyScreen.gameObject.SetActive(false);
        truck.gameObject.SetActive(false);
        car.gameObject.SetActive(false);
        police.gameObject.SetActive(false);
    }

    public void gameOver()
    {
        isGameLost = true;
        gOverScreen.gameObject.SetActive(true);
        timerText.gameObject.SetActive(false);
        isGameActive = false;
    }

    public void gameWon()
    {
        player.gameObject.SetActive(false);
        gWinScreen.gameObject.SetActive(true);
        timerText.gameObject.SetActive(false);
        isGameActive = false;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
