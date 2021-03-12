using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        StartCoroutine(waitOneSecond());
    }

    public void PlayMenuSound()
    {
        SoundManagerScript.PlaySound("menuClick");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    IEnumerator waitOneSecond()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
