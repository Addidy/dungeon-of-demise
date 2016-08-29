using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class Voice : MonoBehaviour {

    public AudioClip[] startPhrases;
    public AudioClip panic;

    private AudioSource audio;

    void Start() {
        int index = Random.Range(0, startPhrases.Length);
        audio = GetComponent<AudioSource>();
        PlayClip(startPhrases[index]);
    }

    public void Panic() {
        PlayClip(panic);
    }

    void PlayClip(AudioClip clip) {
        audio.clip = clip;
        audio.Play();
    }
}