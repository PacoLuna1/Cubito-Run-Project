using UnityEngine.SceneManagement;
using UnityEngine;

public class Endscript : MonoBehaviour
{
    bool JuegoTermino = false;
    public float restartDelay = 1f;
    public GameObject completeLeveUI;

    public void CompleteLevel()
    {
        completeLeveUI.SetActive(true);
    }

    public void GameOver()
    {
        if (JuegoTermino == false)
        {
            JuegoTermino = true;

            Invoke("Restart", restartDelay);
        }

    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}