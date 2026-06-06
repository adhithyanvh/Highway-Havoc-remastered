using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ModeSelect : MonoBehaviour
{
    
    public static int mode;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ModeOne()
    {
        SceneManager.LoadScene(3);
        mode = 1;

    }
    public void ModeTwo()
    {
        SceneManager.LoadScene(4);
        mode = 2;
    }
}
