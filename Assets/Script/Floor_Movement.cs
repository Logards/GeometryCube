using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Floor_Movement : MonoBehaviour
{

    public float speed = 2f;
    public GameObject player;
    public Player_Properties playerPoint;
    private int lastUp = 0;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerPoint = player.GetComponent<Player_Properties>();

        lastUp = playerPoint.point;
        speed += playerPoint.point * 0.05f;
    }

    void Update()
    {
        if (lastUp != playerPoint.point)
        {
            lastUp = playerPoint.point;

            speed += 0.05f;
        }
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}
