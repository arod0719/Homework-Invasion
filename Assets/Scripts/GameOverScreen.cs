using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{

    public Text pointsText;
    public Text winText;
    void Start()
    {
        gameObject.SetActive(true);
        pointsText.text = Score.score + " POINTS";
        if (Score.won)
        {
            winText.text = "You Won!";
            winText.color = Color.blue;
            SoundManagerScript.PlaySound("levelComplete");
        }
        else
        {
            SoundManagerScript.PlaySound("death");
        }
    }

    public void RestartButton()
    {
        SoundManagerScript.PlaySound("menuClick");
        Score.ResetDefault();
        SceneManager.LoadScene("level 0");

    }

    public void ExitButton()
    {
        SoundManagerScript.PlaySound("menuClick");
        Score.ResetDefault();
        GameObject go = GameObject.Find("BackgroundAudio");
        if (go)
            Destroy(go.gameObject);
        SceneManager.LoadScene("menu");
    }
}
