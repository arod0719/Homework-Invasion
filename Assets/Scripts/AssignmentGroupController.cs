using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AssignmentGroupController : MonoBehaviour
{
    private Transform assignmentGroup;
    private float speed = 0.05f; //0.05
    void Start()
    {
        InvokeRepeating("MoveAssignment", 1.0f, 0.01f);
        assignmentGroup = GetComponent<Transform>();
    }

    void MoveAssignment()
    {
        bool moved = false;
        assignmentGroup.position += Vector3.right * speed ;
        foreach (Transform assignment in assignmentGroup)
        {
            if ((assignment.position.x < -8 || assignment.position.x > 8) && !moved)
            {
                speed = -speed;
                assignmentGroup.position += Vector3.down * 0.5f;
                moved = true;
            }
        }
        moved = false;
        if (assignmentGroup.childCount == 1 && System.Math.Abs(speed) <= 0.05f)
        {
            speed = 0.15f;
        }

        else if(assignmentGroup.childCount == 0)
        {
            Score.score += LBCounter.LBCount * 500;
            CancelInvoke();
            SoundManagerScript.PlaySound("levelComplete");
            StartCoroutine(waitThreeSeconds());
            
        }
    }
    IEnumerator waitThreeSeconds()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
