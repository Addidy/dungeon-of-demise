using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class StoneDoor : MonoBehaviour {

    public float openSpeed = 0.1f;

    private bool activated = false;
    private AudioSource audio;
    

    void Start() {
        audio = GetComponent<AudioSource>();
    }

    void Update() {
        if (!activated) { return; }
        if (transform.position.y < 10) {
            transform.position += new Vector3(0, openSpeed * Time.deltaTime, 0);
        }
    }

    public void Activate() {
        activated = true;
        audio.Play();
    }
}
