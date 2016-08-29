using UnityEngine;
using System.Collections;

public class Trap : MonoBehaviour {

    private bool armed = false;

    void Start() {
        FindObjectOfType<GameManager>();
    }

    void Arm() {
        armed = true;
    }

    public virtual void Activate() {
        if (!armed)
            return;
        //Depending on the trap different functionality will be added
    }

    void OnDrawGizmos() {
        Gizmos.DrawIcon(transform.position, "Light Gizmo.tiff", true);
    }
}
