using UnityEngine;
using System.Collections;

public class SlideTrigger : MonoBehaviour {

    public bool makeSlide = true;

    void OnTriggerEnter(Collider col) {
        if (col.GetComponent<Player>()) {
            col.GetComponentInChildren<CameraShake>().isSliding = makeSlide;
            col.GetComponentInChildren<Animator>().SetBool("isSliding", makeSlide);
            if(makeSlide) {
                Destroy(GameObject.FindGameObjectWithTag("Torch"));
            }
            if (!makeSlide) {
                Destroy(FindObjectOfType<BoulderSpin>().gameObject);
            }
        }
    }
}
