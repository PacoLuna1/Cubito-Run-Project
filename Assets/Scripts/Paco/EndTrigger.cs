using UnityEngine;

public class EndTrigger : MonoBehaviour {
    public ManejadorJuego manejadorJuego;

     void OnTriggerEnter()
    {
        manejadorJuego.CompleteLevel();
    }

}
