using UnityEngine.UI;
using UnityEngine;

public class Dice : MonoBehaviour
{
    public Text score;
    public Text highScore;

    public void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    public void RollDice()
    {
        int num = Random.Range(1, 1001);
        score.text = num.ToString();

        if (num > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", num);
            highScore.text = num.ToString();
        }        
    }

    public void Reset()
    {
        PlayerPrefs.DeleteKey("HighScore");
        highScore.text = "0";
    }



}
