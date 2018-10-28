using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour {
    public Text highscoreText;

	// Use this for initialization
	void Start () {
       //highscoreText.text = "Highscore : " + (int)PlayerPrefs.GetFloat ("Highscore");
    }
	
    public void ToGame()
    {
     //   SceneManager.LoadScene("Endless");
    }
}
