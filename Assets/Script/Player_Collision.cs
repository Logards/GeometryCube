using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Collision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ( collision.gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        SceneManager.LoadScene("StartScene");
    }

}
