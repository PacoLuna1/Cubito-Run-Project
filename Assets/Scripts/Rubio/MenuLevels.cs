using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLevels : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void toLevel1()
    {
     //   SceneManager.LoadScene();
    }


    public void toLevel2()
    {
     //   SceneManager.LoadScene();
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
