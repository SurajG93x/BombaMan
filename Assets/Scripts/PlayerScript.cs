using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    public GameObject player;
    Spawner spawner;

    public float speed = 10f;
    private float minX = -2.5f, maxX = 2.5f;

    private void Start()
    {
        spawner = GameObject.FindObjectOfType<Spawner>();
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        float dir = Input.GetAxis("Horizontal");

        Vector3 playerPos = transform.position;
        Vector3 playerScale = transform.localScale;
        Vector3 movement = new Vector3(dir, 0f, 0f);

        float playerScaleX = transform.localScale.x;
        transform.position += movement * Time.deltaTime * speed;

        if (dir < 0)
        {
            playerScale.x = 1; 
        }

        else if (dir > 0)
        {
            playerScale.x = -1;
        }
        transform.localScale = playerScale;

        if (playerPos.x < minX)
        {
            playerPos.x = minX;
            transform.position = playerPos;
        }

        if (playerPos.x > maxX)
        {
            playerPos.x = maxX;
            transform.position = playerPos;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Destroy(player);
            Destroy(spawner);
        }
    }
}
