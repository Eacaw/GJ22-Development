using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevelTrigger : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter()
    {
        Time.timeScale = 0f;
        Scene scene = SceneManager.GetActiveScene();

        if (scene.name != "Level8")
        {
            gameManager.CompleteLevel();
        }
        else
        {
            SceneManager.LoadScene("EndGame");
        }
    }
}
