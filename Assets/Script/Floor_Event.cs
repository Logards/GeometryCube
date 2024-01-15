using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor_Event : MonoBehaviour
{
    public GameObject floor;
    void Start()
    {
        StartCoroutine(ChangeFloorState());
    }

    IEnumerator ChangeFloorState()
    {

        floor.SetActive(false);
        yield return new WaitForSeconds(Random.Range(1,3));
        floor.SetActive(true);
        StartCoroutine(ChangeFloorState());
    }
}
