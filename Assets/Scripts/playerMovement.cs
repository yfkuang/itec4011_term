using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed = 10f;
    public float startX = 0f;
    public float startY = -3.71f;

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
        Debug.Log("GameObject1 collided with " + col.name);
    }
}
