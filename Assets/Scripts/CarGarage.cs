using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class CarGarage : MonoBehaviour
{
    public GameObject[] camPositions;
    public Camera myCamera;
    public Button nextButton;
    public Button selectButton;
    public int carNumber;
    public int cameraNum;
    
    // Start is called before the first frame update
    void Start()
    {
       

    }


    // Update is called once per frame
    void Update()
    {
        /*if (cameraNum == 0)
        {
            myCamera.transform.position = camPositions[0].transform.position;

        }
        else if (cameraNum == 1)
        {
            myCamera.transform.position = camPositions[1].transform.position;

        }
        else if (cameraNum == 2)
        {
            myCamera.transform.position = camPositions[2].transform.position;

        }

        if (cameraNum == 3)
        {
            cameraNum = 0;
        }*/
    }

    //Next button

    public void NextButton()
    {
        cameraNum++;
        Debug.Log(cameraNum);

    }


    //Select button

    public void SelectButton()
    {
        carNumber = cameraNum;
        SceneManager.LoadScene(2);
        Debug.Log(carNumber);

    }


}
