using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignmentController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D target)
    {
        Destroy(target.gameObject);
        if (target.tag == "leisure block")
        {
            Destroy(target.gameObject);
        }

        else if (target.tag == "Player")
        {
            Destroy(target.gameObject);
            //end game
        }
    }
}
