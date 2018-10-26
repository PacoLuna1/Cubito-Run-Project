using UnityEngine;
using UnityEngine.SceneManagement;

public class StartLevels : MonoBehaviour {

    public void StarGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
