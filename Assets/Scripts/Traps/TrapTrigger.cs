using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Collider))]
public class TrapTrigger : MonoBehaviour {

    private Trap trap;

	// Use this for initialization
	void Start () {
        trap = transform.GetComponentInParent<Trap>();
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