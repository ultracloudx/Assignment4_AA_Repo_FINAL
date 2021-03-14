using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class ClockScript : MonoBehaviour
{
    private float timeRemaining = 60f;

    public bool timerIsRunning = false;
    public Text timeText;

    public Rotator rotator;
    public Spawner spawner;
    public Animator animator;

    public void Start()
    {
        timerIsRunning = true;
        if (PlayerPrefs.GetInt("isSave")== 1)
        {
            timeRemaining = PlayerPrefs.GetFloat("currTime");
        }
        else
        {
            timeRemaining = PlayerPrefs.GetFloat("MaxTIME");
        }

    }

    // Update is called once per frame
    void Update()
    {
        

        DisplayTime(timeRemaining);
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                //Debug.Log(timeRemaining);
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                //PlayerPrefs.SetInt("isTimeRemaining", 1);
                timerIsRunning = false;
                EndGame();
            }
        }
        
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void saveCurrTime()
    {
        PlayerPrefs.SetFloat("currTime", timeRemaining);
    }

    public void EndGame()
    {
        

        rotator.enabled = false;
        spawner.enabled = false;

        //animator.SetTrigger("EndGame");

        //gameHasEnded = true;
        Debug.Log("END GAME");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
