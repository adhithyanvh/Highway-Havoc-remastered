using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    [Header("UI")]
    [SerializeField] private TMP_Text scoreText;

    private int retrySceneIndex;

    void Start()
    {
        scoreText.text = ScoreUpdater.instancee.score.ToString("0");

        // Determine retry scene
        if (ModeSelect.mode == 1)
        {
            retrySceneIndex = 3;
        }
        else if (ModeSelect.mode == 2)
        {
            retrySceneIndex = 4;
        }
    }

    public void RetryGame()
    {
        SceneManager.LoadScene(retrySceneIndex);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}