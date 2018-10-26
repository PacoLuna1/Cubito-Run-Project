using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {
    public Transform jugador;
    public Text scoreText;
	// Update is called once per frame
	void Update () {
        scoreText.text = jugador.position.z.ToString("0");
	}
}
