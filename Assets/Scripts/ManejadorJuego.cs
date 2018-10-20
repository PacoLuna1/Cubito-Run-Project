using UnityEngine;
using UnityEngine.SceneManagement;

public class ManejadorJuego : MonoBehaviour {
    bool JuegoTermino = false;
    public float restartDelay = 1f;
    public GameObject completeLeveUI;

    public void CompleteLevel()
    {
        completeLeveUI.SetActive(true);
    }

    public void GameOver()
    {
        if(JuegoTermino == false)
        {
            JuegoTermino = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }
        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
	
}
