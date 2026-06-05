using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class CarSwitchGarage : MonoBehaviour
{
    public GameObject[] cars;
    public GameObject rightBtn, leftBtn;
    public static int selectedCarIndex;
    //public static int carNumber;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        selectedCarIndex = 0;
        ShowSelectedCar();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void ShowSelectedCar()
    {
        foreach(GameObject car in cars)
        {
            car.SetActive(false);
        }
        
            cars[selectedCarIndex].gameObject.SetActive(true);
    }

    public void RightButton()
    {
        if (selectedCarIndex == cars.Length-1)
        {
            selectedCarIndex = 0;
        }
        else
        { 
            selectedCarIndex++;
        }
        ShowSelectedCar();
    }
    public void LeftButton()
    {
        if (selectedCarIndex == 0)
        {
            selectedCarIndex = cars.Length - 1;

        }
        else
        {
            selectedCarIndex--;
        }
        ShowSelectedCar();
    }

    public void selectCar()
    {
        SceneManager.LoadScene(2);
    }
}
