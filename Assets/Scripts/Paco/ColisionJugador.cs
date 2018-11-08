using UnityEngine;

public class ColisionJugador : MonoBehaviour {
    public MovimientoJugador movimiento;
    public int movimientoSalto;
    
      
    public void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "Obstaculo")
        {
            movimiento.enabled = false;

            FindObjectOfType<ManejadorJuego>().GameOver();

        }
        if (collisioninfo.collider.tag == "Escalones")
        {
            movimientoSalto = 0;

        }
    }
    /*
    public void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.collider.tag == "Obstaculo")
        {
            movimiento.enabled = false;

            FindObjectOfType<ManejadorJuego>().GameOver();

        }
        if (hit.collider.tag == "Escalones")
        {
            movimientoSalto = 0;

        }
    }

    */
}
