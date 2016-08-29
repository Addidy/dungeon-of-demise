using UnityEngine;
using System.Collections;

public class SlideTrigger : MonoBehaviour {

    public bool makeSlide = true;

    void OnTriggerEnter(Collider col) {
        print("trigger enter");
        if (col.GetComponent<Player>()) {
            print("");
            col.GetComponentInChildren<CameraShake>().isSliding = makeSlide;
        }
    }
}
