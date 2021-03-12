using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AssignmentController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D target)
    {
        Destroy(target.gameObject);
        if (target.tag == "leisure block")
        {
            SoundManagerScript.PlaySound("impact");
            Destroy(target.gameObject);
        }

        else if (target.tag == "Player")
        {
            Destroy(target.gameObject);
            Score.won = false;
            SceneManager.LoadScene("gameovermenu");
        }
    }
}
