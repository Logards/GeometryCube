using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable_Collision : MonoBehaviour
{
    private GameObject player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            player.GetComponent<Player_Properties>().point += 1;
            Destroy(gameObject);
        }
    }
}
