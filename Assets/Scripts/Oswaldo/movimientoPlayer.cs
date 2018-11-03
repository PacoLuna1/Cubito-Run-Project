using UnityEngine;

public class movimientoPlayer : MonoBehaviour {

    private CharacterController controller;
    private Vector3 moveVector;
    private float verticalVelocity = -1.0f;
    private float speed = 10.0f;
    private float gravity = 12.0f;
    private float startTime;
    private bool isDead = false;
	

    public void Start()
    {
        controller = GetComponent<CharacterController>();
 
    }

    void FixedUpdate () {

        controller.Move(Vector3.forward * 5.0f * Time.deltaTime);

        moveVector = Vector3.zero;

        if (isDead)
            return;

        if (controller.isGrounded)
        {
            verticalVelocity = -5.0f;
        }
        else
        {
            verticalVelocity -= gravity * Time.deltaTime;
        }


        moveVector.x = Input.GetAxisRaw("Horizontal") * speed;

        moveVector.y = verticalVelocity;

        moveVector.z = speed;
        controller.Move(moveVector * Time.deltaTime);        
	}

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "Obstaculo")
            Death();
    }

    private void Death()
    {
        Debug.Log("morii");
        isDead = true;
    }

}
