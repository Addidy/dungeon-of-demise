using UnityEngine;
using System.Collections;

public class VoiceTrigger : MonoBehaviour {

    void OnTriggerEnter(Collider col) {
        col.GetComponent<Voice>().Panic();
    }
}
