using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class MusicToggle : MonoBehaviour
{
    public Toggle musicToggle;
    //public GameObject AudioManager;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleMusic()
    {
        if (musicToggle.isOn)
        {
            //PlayerPrefs.SetInt("music", 1);
            //Set audio volume to 0.15
            Debug.Log("On");
            FindObjectOfType<AudioManager>().Play("BGM");
        }
        else
        {
            //PlayerPrefs.SetInt("music", 0);
            //Set audio volume to 0
            Debug.Log("Off");
            FindObjectOfType<AudioManager>().Pause("BGM");
        }
    }

}
