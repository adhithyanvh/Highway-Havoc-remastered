
using System.Collections;

using UnityEngine;


public class TwoWayTrafficSpawner : MonoBehaviour
{
    public GameObject[] otherCars;
    public GameObject[] lanes;
    int index1, index2;
    
    //public float spawnRepeat;


    // Start is called before the first frame update
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



    void Update()
    {

    }

        public void CarsSpawner()
        {
            index1 = UnityEngine.Random.Range(0, otherCars.Length);
            index2 = UnityEngine.Random.Range(0, lanes.Length);

            GameObject spawnedCar = Instantiate(otherCars[index1], lanes[index2].transform.position, lanes[index2].transform.rotation);

            TwoWayTrafficCarMovement carMovement = spawnedCar.GetComponent<TwoWayTrafficCarMovement>();

            //which lane car is in
            if (carMovement != null)
            {
                carMovement.isRightLane = (index2 == 1); // true = lane 2 (right), false = lane 1 (left)
            }
        }


    }


