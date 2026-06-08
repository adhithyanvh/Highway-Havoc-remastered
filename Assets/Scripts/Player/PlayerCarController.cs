using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCarController : MonoBehaviour
{
    public float moveSpeed = 3f;

    // Lane positions
    public float[] lanePositions;
    public float targetRotationY;
    
    private int currentLane = 1;

    void Start()
    {
        transform.position = new Vector3(
            lanePositions[currentLane],
            transform.position.y,
            transform.position.z
        );
    }

    void Update()
    {
        CarMovements();
    }

    public void CarMovements()
    {
        // Move Right
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            if (currentLane < lanePositions.Length - 1)
            {
                targetRotationY = 50f;

                currentLane++;
            }
        }

        // Move Left
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            if (currentLane > 0)
            {
                targetRotationY = -60f;
                currentLane--;
            }
        }

        // Target lane position
        Vector3 targetPosition = new Vector3(
            lanePositions[currentLane],
            transform.position.y,
            transform.position.z
        );

        Quaternion targetRotation = Quaternion.Euler(0, targetRotationY, 0);

        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation,8 * Time.deltaTime);

        // Smooth lane movement
        transform.position = Vector3.MoveTowards(
            transform.position,
            targetPosition,
            moveSpeed * Time.deltaTime
        );
        targetRotationY = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("OtherCar"))
        {
            Destroy(gameObject);

            SceneManager.LoadScene(5);
        }
    }
}