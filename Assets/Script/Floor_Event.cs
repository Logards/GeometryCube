using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor_Event : MonoBehaviour
{
    public GameObject floor;
    public GameObject top;
    void Start()
    {
        StartCoroutine(ChangeFloorState());
        StartCoroutine(ChangeTopState());
    }

    IEnumerator ChangeFloorState()
    {

        floor.SetActive(false);
        yield return new WaitForSeconds(Random.Range(1,3));
        floor.SetActive(true);
        yield return new WaitForSeconds(Random.Range(1, 3));
        StartCoroutine(ChangeFloorState());
    }

    IEnumerator ChangeTopState()
    {

        top.SetActive(false);
        yield return new WaitForSeconds(Random.Range(1, 3));
        top.SetActive(true);
        yield return new WaitForSeconds(Random.Range(1, 3));
        StartCoroutine(ChangeTopState());
    }
}
