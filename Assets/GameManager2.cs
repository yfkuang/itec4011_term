using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager2 : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    public GameObject spawnPoint;
    public GameObject centerZone;


    // Start is called before the first frame update
    void Start()
    {

    }

    public void NextLevel()
    {
        Instantiate(enemy, centerZone.GetComponent<Detection>().calculateAverage(), Quaternion.identity);
        ResetLevel();
    }

    public void ResetLevel()
    {
        player.transform.position = spawnPoint.transform.position;
        centerZone.GetComponent<Detection>().ResetLevel();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
