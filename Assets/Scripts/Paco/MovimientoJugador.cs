using UnityEngine;

public class MovimientoJugador : MonoBehaviour {
    //This is a reference to the rigidbody component called "rb"
    public Rigidbody rb;
    public float fuerzaAdelante = 2000f;
    public float fuerzaLados = 500f;
    public float MovimientoArriba = 500f;
    public float MovimientoParar = 1000f;
    
    // We marked this as "Fixed" Update because
    // we are using it to mess with physics
    void FixedUpdate () {
        rb.AddForce(0, 0, fuerzaAdelante * Time.deltaTime); // Add a force of 2000 on the z-axis
                                                            // Add Time.deltaTime to express we want to move an object no matter the frames 
        if (Input.GetKey("d"))
        {
            rb.AddForce(fuerzaLados * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }            
        if (Input.GetKey("a"))
        {
            rb.AddForce(-fuerzaLados * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -20f)
        {
            FindObjectOfType<ManejadorJuego>().GameOver();
        }

        if (Input.GetKeyUp(KeyCode.W))
        {

            FindObjectOfType<ColisionJugador>().movimientoSalto += 1;
            

            if (FindObjectOfType<ColisionJugador>().movimientoSalto == 1 || FindObjectOfType<ColisionJugador>().movimientoSalto == 2)
            {
                rb.AddForce(0, MovimientoArriba * Time.deltaTime, 0, ForceMode.VelocityChange);
                
                    
            }
            
            

        }
        
       
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -MovimientoParar * Time.deltaTime);
        }

    }
}
