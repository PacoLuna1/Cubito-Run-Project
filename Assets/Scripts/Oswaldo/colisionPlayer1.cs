using UnityEngine;

public class colisionPlayer1 : MonoBehaviour {

    public movimientoPlayer movimiento;

    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstaculo")
        {
            movimiento.enabled = false;

            FindObjectOfType<Endscript>().GameOver();

        }
    }
	
}
