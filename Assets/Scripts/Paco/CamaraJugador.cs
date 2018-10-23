using UnityEngine;

public class CamaraJugador : MonoBehaviour {
    public Transform jugador;
    public Vector3 compensador;
	// Update is called once per frame
	void Update () {
        transform.position = jugador.position + compensador;
	}
}
