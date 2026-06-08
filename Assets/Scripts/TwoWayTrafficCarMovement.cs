using UnityEngine;

public class TwoWayTrafficCarMovement : MonoBehaviour
{
    public float trafficCarSpeed;

    [Header("Opposite Traffic")]
    public float baseOppositeSpeed = 70f;
    public float speedMultiplier = 0.5f;

    public bool isRightLane;

    void Update()
    {
        trafficCarSpeed = GameSpeedManager.speed;

        // Opposite traffic scaling
        float oppositeCarSpeed =
            baseOppositeSpeed +
            (GameSpeedManager.speed * speedMultiplier);

        // Right lane (toward player)
        if (isRightLane)
        {
            transform.Translate(
                Vector3.forward *
                oppositeCarSpeed *
                Time.deltaTime
            );
        }
        else // Left lane
        {
            transform.Translate(
                Vector3.back *
                trafficCarSpeed *
                Time.deltaTime
            );
        }
    }
}