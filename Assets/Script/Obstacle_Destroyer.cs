using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Obstacle_Destroyer : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle") || collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Collectable"))
        {
            Destroy(collision.gameObject);
        }
    }
}
