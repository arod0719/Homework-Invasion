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
        }
    }

    public void RestartButton()
    {
        Score.ResetDefault();
        SceneManager.LoadScene("level 0");

    }

    public void ExitButton()
    {
        Score.ResetDefault();
        SceneManager.LoadScene("menu");
    }
}
