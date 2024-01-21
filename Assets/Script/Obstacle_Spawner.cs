using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Obstacle_Spawner : MonoBehaviour
{
    public GameObject toSpawn;
    public GameObject player;
    public Player_Properties playerPoint;
    public float defaultSpawnSpeed = 2f;
    public bool isSpawnRandom = false;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerPoint = player.GetComponent<Player_Properties>();
        StartCoroutine(SpawnObstacle());
    }

    IEnumerator SpawnObstacle()
    {
        Vector2 spawnPosition = new Vector2(
            Random.Range(gameObject.GetComponent<BoxCollider2D>().bounds.min.x, gameObject.GetComponent<BoxCollider2D>().bounds.max.x),
            Random.Range(gameObject.GetComponent<BoxCollider2D>().bounds.min.y, gameObject.GetComponent<BoxCollider2D>().bounds.max.y)
        );
        Instantiate(toSpawn, spawnPosition, Quaternion.identity);
        if (!isSpawnRandom)
        {
            yield return new WaitForSeconds(Mathf.Clamp(defaultSpawnSpeed - (playerPoint.point * 0.05f), 0.05f, defaultSpawnSpeed));
        }else
        {
            yield return new WaitForSeconds(Mathf.Clamp(defaultSpawnSpeed - (playerPoint.point * 0.05f), 0.05f, defaultSpawnSpeed) + Random.Range(1f,defaultSpawnSpeed));
        }
        StartCoroutine(SpawnObstacle());
    }
}
