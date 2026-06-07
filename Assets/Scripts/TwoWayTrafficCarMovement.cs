using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoWayTrafficCarMovement : MonoBehaviour
{

        public float trafficCarSpeed;
        public float oppositeCarSpeed = 70f;
        public bool isRightLane; 

        void Update()
        {

        trafficCarSpeed = GameSpeedManager.speed; 

            // Right(toward the player)
            if (isRightLane)
            {
                transform.Translate(Vector3.forward * oppositeCarSpeed * 2f * Time.deltaTime);
            }
            else // Left (away from player)
            {
                transform.Translate(Vector3.back * trafficCarSpeed * Time.deltaTime);
            }
        }
}
