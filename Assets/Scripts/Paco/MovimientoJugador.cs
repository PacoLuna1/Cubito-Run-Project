using UnityEngine;

public class MovimientoJugador : MonoBehaviour {

    public Rigidbody rb;
    private float fuerzaAdelante = 800f;
    private float fuerzaLados = 20f;
    private float MovimientoArriba = 300f;
    private float MovimientoParar = 150f;

    //
    // // Phone
    // public void Izquierda()
    // {
    //
    //
    //         rb.AddForce(-fuerzaLados * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    //
    //
    //
    // }
    //  public void Derecha()
    // {
    //
    //
    //         rb.AddForce(fuerzaLados * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    //
    //
    // }
    //
    // public void Saltar()
    // {
    //     FindObjectOfType<ColisionJugador>().movimientoSalto++;
    //
    //
    //     if (FindObjectOfType<ColisionJugador>().movimientoSalto == 1)
    //     {
    //         rb.AddForce(0, MovimientoArriba * Time.deltaTime, 0, ForceMode.VelocityChange);
    //
    //
    //     }
    //     if (FindObjectOfType<ColisionJugador>().movimientoSalto == 2)
    //     {
    //         rb.AddForce(0, MovimientoArriba * Time.deltaTime, 0, ForceMode.VelocityChange);
    //
    //
    //     }
    // }
    //
    // public void Detener()
    // {
    //
    //         if (rb.velocity.z > 0f)
    //         {
    //             rb.AddForce(0, 0, -MovimientoParar * Time.deltaTime,ForceMode.VelocityChange);
    //         }
    //
    //
    //
    // }
    //
    //
    // void Update()
    // {
    //     if (fuerzaAdelante == 0f)
    //     {
    //         fuerzaAdelante = 400f;
    //     }
    //     rb.AddForce(0, 0, fuerzaAdelante * Time.deltaTime);
    //
    //     if (rb.position.y < -20f)
    //     {
    //         FindObjectOfType<ManejadorJuego>().GameOver();
    //     }
    //
    //
    // }

    // Computer
 void Update()
  {



     rb.AddForce(0, 0, fuerzaAdelante * Time.deltaTime);
     if (Input.GetKey("d"))
      {
          rb.AddForce(fuerzaLados * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

      }
      if (Input.GetKey("a"))
      {
          rb.AddForce(-fuerzaLados * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
      }


     if (Input.GetKey(KeyCode.W) )
      {

         FindObjectOfType<ColisionJugador>().movimientoSalto += 1;


         if (FindObjectOfType<ColisionJugador>().movimientoSalto == 1)
         {
             rb.AddForce(0, MovimientoArriba * Time.deltaTime, 0, ForceMode.VelocityChange);

         }
         if (FindObjectOfType<ColisionJugador>().movimientoSalto == 2)
         {
             rb.AddForce(0, MovimientoArriba * Time.deltaTime, 0, ForceMode.VelocityChange);

         }

     }


      if (rb.position.y < -20f)
      {
          FindObjectOfType<ManejadorJuego>().GameOver();
      }
      if (Input.GetKey("s"))
      {
          rb.AddForce(0, 0, -MovimientoParar * Time.deltaTime);

      }


}
}
