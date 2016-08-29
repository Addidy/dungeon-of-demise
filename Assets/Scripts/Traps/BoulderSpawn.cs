using UnityEngine;
using System.Collections;

public class BoulderSpawn : Trap {

    public GameObject boulder;

    private bool activated = false;

	// Use this for initialization
	void Start () {
	    if(!boulder) {
            print("boulder prefab not specified");
        }
	}

    public override void Activate() {
        base.Activate();
        if(!activated) {
            Instantiate(boulder, transform.position, Quaternion.identity);
            activated = true;
        }
    }
}
