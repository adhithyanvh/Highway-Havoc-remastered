using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficCarMovement : MonoBehaviour
{
    [SerializeField] float speedIncreaser;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speedIncreaser = GameSpeedManager.speed - 0.5f;
        transform.Translate(speedIncreaser * Time.deltaTime * Vector3.back);

    }



}
