using UnityEngine;
using System.Collections;

public class ClosingDoor : Trap {


    public float closeRate = 0.1f;
    public float closedPosition = 1f;

    private bool activated = false;
    private AudioSource audio;
    // Use this for initialization
    void Start() {
        audio = GetComponent<AudioSource>();
        //closeRate *= -1;
    }

    // Update is called once per frame
    void Update () {
	    if(activated && transform.position.y > closedPosition) {
            float newY = Mathf.Lerp(transform.position.y, closedPosition, closeRate * Time.deltaTime);
            transform.position = new Vector3(transform.position.x, newY, transform.position.z);
        }
	}

    public override void Activate() {
        audio.Play();
        activated = true;
    }
}
