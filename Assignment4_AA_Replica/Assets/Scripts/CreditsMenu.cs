using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CreditsMenu : MonoBehaviour
{
    public Text Pins;
    public Text Name;
    public Text PinSpeed;
    public Text RotatorSpeed;
    public Text LivesRemaining;
    public Text LivesChosen;
    public Text TimeRemaining;
    public Text TimeChosen;

    int pinPref;
    //string namePref;
    float pinSpeedPref;
    float rotatorPref;
    int livesLeftPref;
    int livesChosenPref;
    float timeRemainingPref;
    float timeChosenPref;
     

    public void Start()
    {
        pinPref = PlayerPrefs.GetInt("currScore");
        Pins.text = pinPref.ToString();

        Name.text = PlayerPrefs.GetString("PlayerNAME");

        pinSpeedPref = PlayerPrefs.GetFloat("PinSPEED");
        PinSpeed.text = pinSpeedPref.ToString();

        rotatorPref = PlayerPrefs.GetFloat("RotationSPEED");
        RotatorSpeed.text = rotatorPref.ToString();

        livesLeftPref = PlayerPrefs.GetInt("currLives");
        LivesRemaining.text = livesLeftPref.ToString();

        livesChosenPref = PlayerPrefs.GetInt("MaxLIVES");
        LivesChosen.text = livesChosenPref.ToString();

        timeRemainingPref = PlayerPrefs.GetFloat("currTime");

        timeChosenPref = PlayerPrefs.GetFloat("MaxTIME");

        DisplayRemainingTime(timeRemainingPref);
        DisplayChosenTime(timeChosenPref);

    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    public void QuitGame()
    {
        Debug.Log("Quiting Game and going to End Scene");
        Application.Quit();
    }

    void DisplayRemainingTime(float timeToDisplay)
    {
        //timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        TimeRemaining.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void DisplayChosenTime(float timeToDisplay)
    {
        //float timeToDisplay2 = (float)timeToDisplay;

        
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        TimeChosen.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
