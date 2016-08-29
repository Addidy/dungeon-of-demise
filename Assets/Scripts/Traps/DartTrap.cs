using UnityEngine;
using System.Collections;

public class DartTrap : Trap {

    public GameObject dart;
    private bool activated = false;

    public override void Activate() {
        base.Activate();
        if (!activated) {
            Instantiate(dart, transform.position, transform.rotation);
            GetComponent<AudioSource>().Play();
            activated = true;
        }
    }
}
