using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float speed = 5f;
    public float range = 5f;
    public Vector2 direction = Vector2.down;

    void Update()
    {

        if(transform.position.y < GameObject.FindGameObjectWithTag("Player").transform.position.y - range)
        {
            direction = Vector2.up;
        }

        if (transform.position.y > GameObject.FindGameObjectWithTag("Player").transform.position.y + range)
        {
            direction = Vector2.down;
        }

        transform.position = new Vector2(GameObject.FindGameObjectWithTag("Player").transform.position.x + 3, transform.position.y);

        transform.Translate(direction * Time.deltaTime * speed);
    }
}
