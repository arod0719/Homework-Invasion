using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Transform player;
    public float maxBound, minBound;

    public GameObject bullet;
    private float cooldown;

    void Start()
    {
        player = GetComponent<Transform>();
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        if (player.position.x < minBound && horizontal < 0)
        {
            horizontal = 0;
        }
        else if (player.position.x > maxBound && horizontal > 0)
        {
            horizontal = 0;
        }
        player.position += Vector3.right * horizontal * 6.0f * Time.deltaTime;
    }

    private void Update()
    {
        if (Input.GetKeyDown("space") && Time.time > cooldown)
        {
            cooldown = Time.time + 0.5f;
            Instantiate(bullet, player.position, player.rotation);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Score.score = 0;
            SceneManager.LoadScene("level2");
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
        }
    }

}
