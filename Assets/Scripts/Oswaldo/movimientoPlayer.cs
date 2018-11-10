using UnityEngine;

public class movimientoPlayer : MonoBehaviour {

    public Rigidbody rb;
    private float fuerzaAdelante = 900f;
    private float fuerzaLados = 400f;



    // Phone
    public void Izquierda()
    {
        
            rb.AddForce(-fuerzaLados * Time.deltaTime, 0, 0, ForceMode.VelocityChange);


        
    }
    public void Derecha()
    {
        
            rb.AddForce(fuerzaLados * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        
    }
    // We marked this as "Fixed" Update because
    // we are using it to mess with physics
    void FixedUpdate()
    {
        rb.AddForce(0, 0, fuerzaAdelante * Time.deltaTime ); // Add a force of 2000 on the z-axis
                                                            // Add Time.deltaTime to express we want to move an object no matter the frames
      
    }
}
