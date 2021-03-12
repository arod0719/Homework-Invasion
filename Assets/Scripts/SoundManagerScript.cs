using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip death, impact, levelComplete, menuClick, shotFired;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        death = Resources.Load<AudioClip>("death");
        impact = Resources.Load<AudioClip>("impact");
        levelComplete = Resources.Load<AudioClip>("levelComplete");
        menuClick = Resources.Load<AudioClip>("menuClick");
        shotFired = Resources.Load<AudioClip>("shotFired");

        audioSrc = GetComponent<AudioSource>();
    }

    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "death":
                audioSrc.PlayOneShot(death);
                break;
            case "impact":
                audioSrc.PlayOneShot(impact);
                break;
            case "levelComplete":
                audioSrc.PlayOneShot(levelComplete);
                break;
            case "menuClick":
                audioSrc.PlayOneShot(menuClick);
                break;
            case "shotFired":
                audioSrc.PlayOneShot(shotFired);
                break;
        }
    }
}
