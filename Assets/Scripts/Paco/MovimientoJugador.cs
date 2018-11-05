using UnityEngine;

public class MovimientoJugador : MonoBehaviour {
    //This is a reference to the rigidbody component called "rb"
    public Rigidbody rb;
    //public float fuerzaAdelante = 1f;
   public float fuerzaLados = 50f;
    public float MovimientoArriba = 500f;
    public float MovimientoParar = 800f;

    // Phone control
    public Vector3 moveVector;
    public float verticalVelocity = -1.0f;
    public float gravity = 12.0f;
    public float speed = 10.0f;
    public float startTime;
    public CharacterController controller;


    // We marked this as "Fixed" Update because
    // we are using it to mess with physics
    void Start()
    {
        controller = GetComponent<CharacterController>();
        startTime = Time.time;
    }
    void FixedUpdate () {

        // rb.AddForce(0, 0, fuerzaAdelante * Time.deltaTime); // Add a force of 2000 on the z-axis
        // Add Time.deltaTime to express we want to move an object no matter the frames

        //if (Input.GetKey("d"))
        //{
         //   rb.AddForce(fuerzaLados * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
       // }
        //if (Input.GetKey("a"))
        //{
         //   rb.AddForce(-fuerzaLados * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        //}

        if(rb.position.y < -20f)
        {
            FindObjectOfType<ManejadorJuego>().GameOver();
        }
       
        else{

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
    

      /*  if (Input.GetKey(KeyCode.W))
        {

            FindObjectOfType<ColisionJugador>().movimientoSalto++;
            

            if (FindObjectOfType<ColisionJugador>().movimientoSalto == 1 )
            {
                rb.AddForce(0, MovimientoArriba * Time.deltaTime, 0, ForceMode.VelocityChange);
                Debug.Log(FindObjectOfType<ColisionJugador>().movimientoSalto);

            }
            if (FindObjectOfType<ColisionJugador>().movimientoSalto == 4)
            {
                rb.AddForce(0, MovimientoArriba * Time.deltaTime, 0, ForceMode.VelocityChange);
                Debug.Log(FindObjectOfType<ColisionJugador>().movimientoSalto);

            }



        }*/


        if(Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -MovimientoParar * Time.deltaTime);
        }

    }
}
