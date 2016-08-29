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
        transform.position += new Vector3(0, openSpeed, 0);
    }

    public void Activate() {
        activated = true;
        audio.Play();
    }
}
