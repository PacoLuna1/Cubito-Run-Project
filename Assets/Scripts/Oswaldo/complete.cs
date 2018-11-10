using UnityEngine.SceneManagement;
using UnityEngine;

public class complete : MonoBehaviour {

	public void loadNextLevel ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
