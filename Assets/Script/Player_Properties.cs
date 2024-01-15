using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player_Properties : MonoBehaviour
{
    public int point = 0;
    public TMP_Text count;

    void Update()
    {
        count.SetText(point.ToString());
    }
}
