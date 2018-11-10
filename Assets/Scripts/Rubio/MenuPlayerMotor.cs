using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPlayerMotor : MonoBehaviour {
private CharacterController controller;
private Vector3 moveVector;
private float verticalVelocity = -5.0f;
public float speed = 2.0f;
private float gravity = 12.0f;

	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController>();
	}

	// Update is called once per frame
	void Update () {
		controller.Move(Vector3.forward * speed * Time.deltaTime);

		moveVector = Vector3.zero;

		if (controller.isGrounded)
		{
				verticalVelocity = -0.5f;
		}
		else
		{
				verticalVelocity -= gravity * Time.deltaTime;
		}

		// X value Left Rigth Desktop
			moveVector.x = Input.GetAxisRaw("Horizontal") * (speed * 0.80f);

		// X value Left Rigth Phone
		if (Input.GetMouseButton(0))
		{
				// Rigth side of the screen
				if (Input.mousePosition.x > Screen.width / 2)
						moveVector.x = speed;
				else
						moveVector.x = -speed;
		}

		// Y value Up Down
		moveVector.y = verticalVelocity;


		// Z value Foward Backward Desktop
		moveVector.z = speed;
		controller.Move(moveVector * Time.deltaTime);
	}
}
