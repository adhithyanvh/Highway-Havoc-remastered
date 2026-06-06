using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FailScene : MonoBehaviour
{
    public Button retry1, retry2;
    public TMP_Text scoreOrig;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreOrig.text = "" + ScoreUpdater.instancee.score.ToString("0");

        if(ModeSelect.mode == 1)
        {
            retry1.gameObject.SetActive(true);
            retry2.gameObject.SetActive(false);
        }
        if(ModeSelect.mode == 2)
        {
            retry2.gameObject.SetActive(true);
            retry1.gameObject.SetActive(false);
        }
    }

    public void Retry1()
    {
        SceneManager.LoadScene(3);
    }

    public void Retry2()
    {
        SceneManager.LoadScene(4);
    }

    public void ToHome()
    {
        SceneManager.LoadScene(0);
    }
}
