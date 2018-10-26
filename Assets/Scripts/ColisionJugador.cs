using UnityEngine;

public class ColisionJugador : MonoBehaviour {
    public MovimientoJugador movimiento;
    public int movimientoSalto;
    
    
       public void OnCollisionEnter(Collision collisionInfo)
    {
       if(collisionInfo.collider.tag == "Obstaculo"){
            movimiento.enabled = false;

            FindObjectOfType<ManejadorJuego>().GameOver();
            
        }
        if (collisionInfo.collider.tag == "Escalones")
        {
            movimientoSalto = 0;

        }
       
    }
    
    

        
}
