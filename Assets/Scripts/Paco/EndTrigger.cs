using UnityEngine;

public class EndTrigger : MonoBehaviour {
    public Endscript endscript;

     void OnTriggerEnter()
    {
        endscript.CompleteLevel();
    }

}
