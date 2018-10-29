using UnityEngine;
using UnityEngine.SceneManagement;

public class StartLevels : MonoBehaviour {

    public void StarGame()
    {
        SceneManager.LoadScene("MenuLvls");
    }
}
