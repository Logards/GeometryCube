using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Obstacle_Spawner : MonoBehaviour
{
    public GameObject toSpawn;
    void Start()
    {
        StartCoroutine(SpawnObstacle());
    }

    IEnumerator SpawnObstacle()
    {
        Vector2 spawnPosition = new Vector2(
            Random.Range(gameObject.GetComponent<BoxCollider2D>().bounds.min.x, gameObject.GetComponent<BoxCollider2D>().bounds.max.x),
            Random.Range(gameObject.GetComponent<BoxCollider2D>().bounds.min.y, gameObject.GetComponent<BoxCollider2D>().bounds.max.y)
        );
        Instantiate(toSpawn, spawnPosition, Quaternion.identity);
        yield return new WaitForSeconds(2f);
        StartCoroutine(SpawnObstacle());
    }
}
