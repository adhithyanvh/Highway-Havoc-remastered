using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class PlayerCarSpawner : MonoBehaviour
{
    public GameObject Player;
    public GameObject[] PlayerCars;
   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(PlayerCars[CarSwitchGarage.selectedCarIndex], Player.transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
