using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayandNight : MonoBehaviour
{
    Vector3 rotate =  Vector3.zero;
    float degPerSec = 6;
    // Update is called once per frame
    void Update()
    {
        rotate.x = degPerSec * Time.deltaTime;
        transform.Rotate(rotate, Space.World);
    }
}
