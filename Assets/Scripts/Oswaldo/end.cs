using UnityEngine;

public class end : MonoBehaviour {

    public Endscript endscript;

    private void OnTriggerEnter()
    {
        endscript.CompleteLevel();
    }
}
