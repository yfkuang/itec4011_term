using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    public GameObject Player;
    public float speed = 8f;
    public float startX = 0f;
    public float startY = 0f;

    // Start is called before the first frame update
    void Start()
    {
        startX = transform.position.x;
        startY = transform.position.y;
    }

    public void setStartPosition(Vector2 vec)
    {
        transform.position = vec;
        startX = vec.x;
        startY = vec.y;

    }

    public void ResetPosition()
    {
        transform.position = new Vector2(startX, startY);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;

        if (pos.x > Player.transform.position.x && transform.position.x > startX - 3)
        {
            pos.x -= speed * Time.deltaTime;
        }
        else if (pos.x < Player.transform.position.x && transform.position.x < startX + 3)
        {
            pos.x += speed * Time.deltaTime;
        }

        transform.position = pos;
    }

    public void resetPosition()
    {
        Vector2 pos;
        pos.x = startX;
        pos.y = startY;
        transform.position = pos;
    }
}
