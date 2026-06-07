using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadLoopManager : MonoBehaviour
{
    public GameObject road1, road2, road3;
    public GameObject point1, point2;

    private void Update()
    {
        if (road1.transform.position.z <= point1.transform.position.z)
        {
            road1.transform.position = point2.transform.position;
        }

        if (road2.transform.position.z <= point1.transform.position.z)
        {
            road2.transform.position = point2.transform.position;
        }

        if (road3.transform.position.z <= point1.transform.position.z)
        {
            road3.transform.position = point2.transform.position;
        }
    }
}