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
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
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
