using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DupliSpawnObjMove : MonoBehaviour
{
 
        public float otherCarSpeed;
        

        public bool isRightLane; 

        public int speedMultiplier = 1;

        void Update()
        {
            if (GameSpeedManager.speed >= 55)
            {
                speedMultiplier = 3;
            }

            otherCarSpeed = UnityEngine.Random.Range(GameSpeedManager.speed, GameSpeedManager.speed * speedMultiplier);

            // Right(toward the player)
            if (isRightLane)
            {
                transform.Translate(Vector3.forward * otherCarSpeed * 2 * Time.deltaTime);
            }
            else // Left (away from player)
            {
                transform.Translate(Vector3.back * otherCarSpeed * Time.deltaTime);
            }
        }
    




}
