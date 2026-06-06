using UnityEngine;

public class GameSpeedManager : MonoBehaviour
{
    public static float speed = 50;
    public float speedIncreaseRate = 3f;
    public float brakeFactor = 5f; 
    private float timeElapsed = 0f;
    public float timeBetweenIncreases = 0.1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Increase speed over time
        timeElapsed += Time.deltaTime;
        if (timeElapsed >= timeBetweenIncreases)
        {
            speed += speedIncreaseRate;
            timeElapsed = 0f; 
        }

        // Brake
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("speed applied" + speed);
            speed -= brakeFactor * Time.deltaTime; // Apply the brake gradually
            if (speed < 40) speed = 40; // Prevent speed from going negative
        }
    }
}
