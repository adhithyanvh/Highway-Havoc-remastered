using System.Collections;
using UnityEngine;

public class TrafficSpawner : MonoBehaviour
{
    public GameObject[] otherCars;
    public GameObject[] lanes;

    int randomCarIndex;
    int randomLaneIndex;

    void Start()
    {
        StartCoroutine(SpawnTraffic());
    }

    IEnumerator SpawnTraffic()
    {
        while (true)
        {
            CarsSpawner();

            float randomSpawnTime = Random.Range(2f, 3f);

            yield return new WaitForSeconds(randomSpawnTime);
        }
    }

    public void CarsSpawner()
    {
        randomCarIndex = Random.Range(0, otherCars.Length);
        randomLaneIndex = Random.Range(0, lanes.Length);

        Instantiate(
            otherCars[randomCarIndex],
            lanes[randomLaneIndex].transform.position,
            Quaternion.identity
        );
    }
}