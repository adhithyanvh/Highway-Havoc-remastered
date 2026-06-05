using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class PlayerCarMovements : MonoBehaviour
{

    public GameObject Playerr;
    public GameObject[] PlayerCars;


    // Start is called before the first frame update
    void Start()
    {
        // Car will be spawned depending on the carNumber!

       /* if (CarGarage.instance.carNumber == 0)
        {
            Instantiate(PlayerCars[CarGarage.instance.carNumber], Playerr.transform.position, Quaternion.identity);

        }

        if (CarGarage.instance.carNumber == 1)
        {
            Instantiate(PlayerCars[CarGarage.instance.carNumber], Playerr.transform.position, Quaternion.identity);

        }

        if (CarGarage.instance.carNumber == 2)
        {
            Instantiate(PlayerCars[CarGarage.instance.carNumber], Playerr.transform.position, Quaternion.identity);

        }*/
    }

    // Update is called once per frame
    void Update()
    {




    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("OtherCar"))
        {

            Destroy(gameObject);
          
            Debug.Log("Car hit!");
        }
    }

    
}
