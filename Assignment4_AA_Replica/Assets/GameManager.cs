using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private bool gameHasEnded = false;

    public Rotator rotator;
    public Spawner spawner;

    //public Text remainingLives;

    public Animator animator;

    public void Awake()
    {
        
    }

    public void Update()
    {
        
    }

    public void Loss()
    {
        

        rotator.enabled = false;
        spawner.enabled = false;

        animator.SetTrigger("EndGame");
        animator.SetTrigger("Idle");

        gameHasEnded = true;
        Debug.Log("LOSE!");
    }

    public void EndGame()
    {
        if (gameHasEnded)
        {
            return;
        }

        rotator.enabled = false;
        spawner.enabled = false;

        animator.SetTrigger("EndGame");

        gameHasEnded = true;
        Debug.Log("END GAME");
    }

    // RestartLevel() is used as an Event in the animation window
    public void RestartLevel()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        /*if ( (PlayerPrefs.GetInt("isTimeRemaining") == 1))
        {
            PlayerPrefs.SetInt("isSave", 0);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }*/
        Score.remainingLives--;
        PlayerPrefs.SetInt("currLives", Score.remainingLives);
        if (Score.remainingLives == 0 )
        {
            PlayerPrefs.SetInt("isSave", 0);
            /*if (PlayerPrefs.GetInt("isTimeReamining") == 1)
            {
                PlayerPrefs.SetInt("isTimeRemaining", 0);
            }*/
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
        gameHasEnded = false;
        rotator.enabled = true;
        spawner.enabled = true;
    }
}
