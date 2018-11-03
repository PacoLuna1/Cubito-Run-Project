using UnityEngine;

public class seguirPlayer1 : MonoBehaviour {

    public Transform player;
    public Vector3 offset;

	void Update () {
        transform.position = player.position + offset;
	}
}
