using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detection : MonoBehaviour
{

    private List<Vector2> playerPositions;
    Vector2 avargePosition;

    // Start is called before the first frame update
    void Start()
    {
        playerPositions = new List<Vector2>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Vector2 calculateAverage()
    {
        float xAverage = 0;
        float yAverage = 0;
        foreach (Vector2 vec in playerPositions)
        {
            xAverage += vec.x;
            yAverage += vec.y;
        }

        xAverage = xAverage / playerPositions.Count;
        yAverage = yAverage / playerPositions.Count;

        return new Vector2(xAverage, yAverage);
    }

    public void ResetLevel()
    {
        playerPositions = new List<Vector2>();
    }


    void OnTriggerStay2D(Collider2D collision)
    {
        playerPositions.Add(collision.transform.position);
    }
}
