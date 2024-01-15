using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{

    public GameObject target;
    private GameObject currentTarget;
    public float forcePower = 2f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (currentTarget == null)
        {
            if (Input.GetMouseButtonDown(0))
            {
                currentTarget = Instantiate(target, new Vector2(transform.position.x + 3, transform.position.y), Quaternion.identity);
                currentTarget.GetComponent<Target>().direction = Vector2.up;
                rb.velocity = Vector3.zero;
            }
            else if (Input.GetMouseButtonDown(1))
            {
                currentTarget = Instantiate(target, new Vector2(transform.position.x + 3, transform.position.y), Quaternion.identity);
                currentTarget.GetComponent<Target>().direction = Vector2.down;
                rb.velocity = Vector3.zero;
            }
        }
        

        if (currentTarget != null)
        { 

            if (Input.GetMouseButtonUp(0) || Input.GetMouseButtonUp(1))
            {
                Vector2 direction = currentTarget.transform.position - transform.position;
                rb.AddForce(direction * forcePower, ForceMode2D.Impulse);

                Destroy(currentTarget);
            }
        }
    }
}
