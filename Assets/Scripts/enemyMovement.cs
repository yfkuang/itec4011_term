using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    public GameObject Player;
    public float speed = 8f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;

        if (pos.x > Player.transform.position.x)
        {
            pos.x -= speed * Time.deltaTime;
        }
        else if (pos.x < Player.transform.position.x)
        {
            pos.x += speed * Time.deltaTime;
        }

        transform.position = pos;
    }
}
