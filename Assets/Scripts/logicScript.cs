using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class logicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource src;
    public AudioClip deathSFX, dingSFX;
    //private birdScript bird;


    /* public static logicScript Instance { get; private set; }

     This is a singleton class
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    */

    /*
     public void startGame()
    {
        
        SceneManager.LoadScene(1);
        
    }
    */
    [ContextMenu("Increase score")]
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
        src.clip = dingSFX;
        src.Play();

        
    }
    public void restartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        gameOverSound();
       
        }
    public void gameOverSound()
    {
        if (gameOverScreen.activeInHierarchy)
        {
            src.clip = deathSFX;
            src.Play();
        }
    }

    
}
