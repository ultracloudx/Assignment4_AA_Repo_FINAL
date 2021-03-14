using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int PinCount = 0;
    public static int remainingLives = 1;

    public Text text;
    public Text remainingLivesText;

    
    private void Awake()
    {
        
    }

    private void Start()
    {
        int livesPref = PlayerPrefs.GetInt("MaxLIVES");
        if (PlayerPrefs.GetInt("isSave") == 1) 
        { 
            remainingLives = PlayerPrefs.GetInt("currLives");
            PinCount = PlayerPrefs.GetInt("currScore");
        } else 
        { 
            remainingLives = livesPref;
            PinCount = 0;
        }
        
        
    }

    private void Update()
    {
        setPlayerRemainingLives(remainingLives);
        text.text = PinCount.ToString();
    }

    public void setPlayerRemainingLives(int maxLives)
    {
        remainingLivesText.GetComponent<Text>().text = maxLives.ToString();
    }
}
