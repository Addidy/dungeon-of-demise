using UnityEngine;
using System.Collections;

public class BoulderTeleport : Trap {


    public GameObject boulderPrefab;
    private bool activated = false;


    public override void Activate() {
        base.Activate();
        if (!activated) {
            activated = true;
            if (!FindObjectOfType<Boulder>()) {
                Instantiate(boulderPrefab, transform.position, Quaternion.identity);
                return;
            }
            GameObject boulder = FindObjectOfType<Boulder>().gameObject;
            boulder.GetComponent<NavMeshAgent>().Warp(transform.position);
        }
    }
}
