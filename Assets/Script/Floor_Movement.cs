using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Floor_Movement : MonoBehaviour
{

    public float speed = 2f;

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}
