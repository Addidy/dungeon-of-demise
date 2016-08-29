using UnityEngine;
using System.Collections;

public class BoulderDistanceFromPlayer : MonoBehaviour {

    public float distance = 100000000;

    private GameObject player;
    private GameObject boulder;

	// Use this for initialization
	void Start () {
        distance = 1000000;
        player = FindObjectOfType<Player>().gameObject;
	}
	
	// Update is called once per frame
	void Update () {
        if(!FindObjectOfType<Boulder>()) {
            return;
        }
        boulder = FindObjectOfType<Boulder>().gameObject;
        Vector3 playerPos = player.transform.position;
        Vector3 boulderPos = boulder.transform.position;
        distance = Vector3.Distance(playerPos, boulderPos);        
	}
}