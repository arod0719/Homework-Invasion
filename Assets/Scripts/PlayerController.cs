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
    Animator animator;

    void Start()
    {
        player = GetComponent<Transform>();
        animator = GetComponent<Animator>();
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
        animator.SetFloat("Move X", horizontal);
        player.position += Vector3.right * horizontal * 6.0f * Time.deltaTime;
    }

    private void Update()
    {
        if (Input.GetKeyDown("space") && Time.time > cooldown)
        {
            cooldown = Time.time + 0.4f;
            Instantiate(bullet, player.position, player.rotation);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Score.score = 0;
            SceneManager.LoadScene("menu");
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) && SceneManager.GetActiveScene().buildIndex != 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && SceneManager.GetActiveScene().buildIndex != 4)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

}
