using UnityEngine;

public class movimientoPlayer : MonoBehaviour {

    public Rigidbody rb;
    public float fuerzaAdelante = 200f;
    public float fuerzaLados = 50f;
    

    // We marked this as "Fixed" Update because
    // we are using it to mess with physics
    void FixedUpdate()
    {
        rb.AddForce(0, 0, fuerzaAdelante * Time.deltaTime ); // Add a force of 2000 on the z-axis
                                                            // Add Time.deltaTime to express we want to move an object no matter the frames
        if (Input.GetKey("d"))
        {
            rb.AddForce(fuerzaLados * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-fuerzaLados * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -10f)
        {
            FindObjectOfType<Endscript>().GameOver();
        }
    }
}
