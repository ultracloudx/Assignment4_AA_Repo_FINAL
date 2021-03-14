using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class NameInputScript : MonoBehaviour
{
    public string userNameInput;
    public GameObject inputField;
    public Button PlayButton;


    public void StoreName()
    {
        userNameInput = inputField.GetComponent<Text>().text;
        Debug.Log(userNameInput);
        
    }

    public void playButton()
    {
        if (userNameInput == "")
        {
            Debug.Log("No Name!");
        }
        else
        {
            PlayerPrefs.SetString("PlayerNAME", userNameInput);
            PlayerPrefs.SetInt("isSave", 0);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        
    }
}
