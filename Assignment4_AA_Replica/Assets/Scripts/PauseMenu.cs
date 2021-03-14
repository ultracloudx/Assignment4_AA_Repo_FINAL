using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{

    public static bool GameIsPaused = false;
    //public Text displayName;

    public GameObject pauseMenuUI;
    public Text playerName;
    public Text playerLives;
    //public Text remainingLivesText;

    //private int remainingLives = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Awake()
    {
        string namePref = PlayerPrefs.GetString("PlayerNAME");
        setPlayerName(namePref);
        int livesPref = PlayerPrefs.GetInt("MaxLIVES");
        setPlayerMaxLives(livesPref);
        
    }

    public void setPlayerName(string name)
    {
        if (name != "")
        {
            playerName.GetComponent<Text>().text = name;
        }
        else
        {
            Debug.Log("No name!");
            playerName.GetComponent<Text>().text = "No Name!";
        }

    }

    public void setPlayerMaxLives(int maxLives)
    {
        playerLives.GetComponent<Text>().text = maxLives.ToString();
    }

    /*public void setPlayerRemainingLives(int maxLives)
    {
        remainingLivesText.GetComponent<Text>().text = maxLives.ToString();
    }*/

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void menuButton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void QuitGame()
    {
        Time.timeScale = 1f;
        Debug.Log("Quiting Game and going to End Scene");
        //Application.Quit();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void SaveNQuit()
    {
        Time.timeScale = 1f;
        Debug.Log("Saved and returned to menu");
        //PlayerPrefs.SetFloat("currTime",60f);
        Debug.Log(PlayerPrefs.GetFloat("currTime"));
        //PlayerPrefs.SetInt("currLives",1);
        Debug.Log(PlayerPrefs.GetInt("currLives"));
        //PlayerPrefs.SetInt("currScore",1);
        Debug.Log(PlayerPrefs.GetInt("currScore"));
        PlayerPrefs.SetInt("isSave", 1); //1 for save
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        
        

    }
}
