using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsMotor : MonoBehaviour {
public PlayerMotor player;
	// Use this for initialization
	void Start () {
		gameObject.SetActive(true);
	}

	// Update is called once per frame
	void Update () {
		if(player.isDead)
			gameObject.SetActive(false);
	}


}
