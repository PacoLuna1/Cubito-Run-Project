using UnityEngine;

public class SoundCrash : MonoBehaviour {

    public AudioClip sonido = null;
    public float volumen = 1.0f;
    protected Transform posicion = null;

    public void Start()
    {
        posicion = transform;
    }

    public void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "Obstaculo")
        {
            AudioSource.PlayClipAtPoint(sonido, posicion.position, volumen);
        }
        
    }
}
