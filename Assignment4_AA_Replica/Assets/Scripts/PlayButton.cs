using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class PlayButton : MonoBehaviour
{
    public Button button;

    public void playButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
