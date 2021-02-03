using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{

    private Transform bullet;
    public GameObject assignment;

    // Start is called before the first frame update
    void Start()
    {
        bullet = GetComponent<Transform>();
        assignment = (GameObject)Resources.Load("Assignment", typeof(GameObject));
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        bullet.position += Vector3.up * 18.0f * Time.deltaTime;
        if (bullet.position.y >= 10)
            Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "leisure block")
        {
            Destroy(target.gameObject);
            Destroy(gameObject);
        }
        else if (target.tag == "assignment")
        {
            Destroy(target.gameObject);
            Destroy(gameObject);
            Score.score += 100;
        }
        else if (target.tag == "assignmentRed")
        {
            Transform location = target.transform;
            Destroy(target.gameObject);
            Destroy(gameObject);
            assignment = Instantiate(assignment, location.position, location.rotation, location.parent);
        }
    }
}
