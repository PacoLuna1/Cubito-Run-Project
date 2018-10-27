using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour {
    private CharacterController controller;
    private Vector3 moveVector;
    private float verticalVelocity = 0.0f;
    private float speed = 5.0f;
    private float gravity = 12.0f;
    private float animationDuration = 3.0f;
    private bool isDead = false;
    private float startTime;

	// Use this for initialization
	void Start () {
        controller = GetComponent<CharacterController>();
        startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
      
        if( Time.time - startTime < animationDuration)
        {
            controller.Move(Vector3.forward * speed * Time.deltaTime);
            return;
        }else
        {

            if (isDead)
                return;

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
            moveVector.x = Input.GetAxisRaw("Horizontal") * speed;
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

    public void SetSpeed(float modifier)
    {
        speed = 5.0f + modifier;
    }

    // It is begin called every time our capsule hits something
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.point.z > transform.position.z + (controller. radius /2) )
            Death();
    }

    private void Death()
    {
        isDead = true;
        GetComponent<Score>().onDeath();
    }


}
