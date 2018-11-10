using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuLevels : MonoBehaviour {
    public Text highscoreText;

	// Use this for initialization
	void Start () {
        highscoreText.text = "Highscore: " + (int)PlayerPrefs.GetFloat("Highscore");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void toLevel1()
    {
        SceneManager.LoadScene("Level 1-Easy");
    }


    public void toLevel2()
    {
        SceneManager.LoadScene("Level 2-Easy");
    }


    public void toLevel3()
    {
         SceneManager.LoadScene("Nivel 3-Hard");
    }


    public void toLevel4()
    {
        SceneManager.LoadScene("Nivel 4-Medium");
    }


    public void toLevel5()
    {
        SceneManager.LoadScene("Endless");
    }
}
