using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Collider))]
public class TrapTrigger : MonoBehaviour {

    public Trap trap;

	// Use this for initialization
	void Start () {
	    if(!trap) {
            print("No Trap set");
        }
	}

    void OnTriggerEnter(Collider col) {
        if(col.GetComponent<Player>()) {
            trap.Activate();
        }
    }

    void OnDrawGizmos() {
        Gizmos.DrawIcon(transform.position, "Light Gizmo.tiff", true);
    }
}