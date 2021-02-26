using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingLb : MonoBehaviour
{
    private Transform leisureGroup;
    private float speed = 0.04f;
    void Start()
    {
        InvokeRepeating("MoveLeisureBlock", 1.0f, 0.01f);
        leisureGroup = GetComponent<Transform>();
    }

    void MoveLeisureBlock()
    {
        bool moved = false;
        leisureGroup.position += Vector3.right * speed;
        foreach (Transform block in leisureGroup)
        {
            if ((block.position.x < -8 || block.position.x > 8) && !moved)
            {
                speed = -speed;
                moved = true;
            }
        }
        moved = false;
    }
}
