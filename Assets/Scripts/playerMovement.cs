using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed = 10f;
    public GameObject endZone;
    public GameObject gameManager;

    void Update()
    {
        Vector2 pos = transform.position;

        if (Input.GetKey("w") || Input.GetKey("up"))
        {
            pos.y += speed * Time.deltaTime;
        }
        if (Input.GetKey("s") || Input.GetKey("down"))
        {
            pos.y -= speed * Time.deltaTime;
        }
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            pos.x += speed * Time.deltaTime;
        }
        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            pos.x -= speed * Time.deltaTime;
        }

        transform.position = pos;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.transform.Equals(endZone.transform))
        {
            gameManager.GetComponent<GameManager2>().NextLevel();
        }
    }
}
