using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager2 : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    public List<GameObject> enemies;
    public GameObject spawnPoint;
    public GameObject centerZone;

    // Start is called before the first frame update
    void Start()
    {
        enemies = new List<GameObject>();
    }

    public void NextLevel()
    {
        Vector2 enemySpawn = centerZone.GetComponent<Detection>().calculateAverage();
        GameObject tempEnemy = Instantiate(enemy, enemySpawn, Quaternion.identity);
        tempEnemy.GetComponent<enemyMovement>().Player = player;
        enemies.Add(tempEnemy);
        ResetLevel();
    }

    public void ResetLevel()
    {
        player.transform.position = spawnPoint.transform.position;
        resetEnemies();
        centerZone.GetComponent<Detection>().ResetLevel();
    }

    public void resetEnemies()
    {
        foreach(GameObject e in enemies)
        {
            e.GetComponent<enemyMovement>().resetPosition();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
