using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;
using System;

public class MainMenu : MonoBehaviour
{
    public Slider RotationSlider;
    public Text rotationSliderText;
    public Slider pinSlider;
    public Text pinSliderText;

    private static float rotationSpeed = 1f;
    private static float pinSpeed = 2f;
    private static int livesPref = 1;
    private static float timePref = 60f;


    public void FixedUpdate()
    {
        
    }
    public void setRotationSpeed()
    {
        //default is uhh 100f? Slider sets from 1 to 5
        rotationSliderText.text = RotationSlider.value.ToString("");
        rotationSpeed = RotationSlider.value * 100;
        Debug.Log(rotationSpeed);
        PlayerPrefs.SetFloat("RotationSPEED", rotationSpeed);
    }

    public void setPinSpeed()
    {
        //default is currently 200f. Slider sets from 1 to 5
        pinSliderText.text = pinSlider.value.ToString("");
        pinSpeed = pinSlider.value * 10;
        Debug.Log(pinSpeed);
        PlayerPrefs.SetFloat("PinSPEED", pinSpeed);
    }

    public void setLivesDropdown(int livesIndex)
    {
        int i = 0;
        switch (livesIndex)
        {
            case 0:
                i = 1;
                livesPref = 1;
                Debug.Log(i);
                //PlayerPrefs.SetInt("MaxLIVES", i);
                break;
            case 1:
                i = 3;
                livesPref = 3;
                Debug.Log(i);
                //PlayerPrefs.SetInt("MaxLIVES", i);
                break;
            case 2:
                i = 5;
                livesPref = 5;
                Debug.Log(i);
                //PlayerPrefs.SetInt("MaxLIVES", i);
                break;
            default:
                i = 1;
                livesPref = 1;
                Debug.Log(i);
                //PlayerPrefs.SetInt("MaxLIVES", i);
                break;

        }
    }

    public void setTimeDropdown(int timeIndex)
    {
        int i = 0;
        switch (timeIndex)
        {
            case 0:
                i = 1;
                timePref = 60;
                Debug.Log(i + "= 1:00");
                break;
            case 1:
                i = 2;
                timePref = 120;
                Debug.Log(i + "= 2:00");
                break;
            case 2:
                i = 3;
                timePref = 180;
                Debug.Log(i + "= 3:00");
                break;
            default:
                i = 1;
                timePref = 60;
                Debug.Log(i + "= 1:00");
                break;

        }
    }

    public void ApplySettings()
    {
        PlayerPrefs.SetInt("isSave", 0);
        Debug.Log("Save Reset");

        PlayerPrefs.SetFloat("RotationSPEED", rotationSpeed);
        Debug.Log("Saved Rotation: " + rotationSpeed);
        PlayerPrefs.SetFloat("PinSPEED", pinSpeed);
        Debug.Log("Saved Pin: " + pinSpeed);
        PlayerPrefs.SetInt("MaxLIVES", livesPref);
        Debug.Log("Saved Lives: " + livesPref);
        PlayerPrefs.SetFloat("MaxTIME", timePref);
        Debug.Log("Saved Time: " + timePref);
    }

    public void QuitGame()
    {
        Debug.Log("Quit successful");
        Application.Quit();
    }

    public void LoadGame()
    {
        if (PlayerPrefs.GetInt("currLives") > 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            Debug.Log("No lives, no save!");
        }
        
    }
}
