using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class LoseVoice : MonoBehaviour {
    public float delay = 1f;
    public AudioClip[] sadPhrase;
    private AudioSource audio;
    private bool activated = false;

    void PlayClip(AudioClip clip) {
        audio.clip = clip;
        audio.Play();
    }

    void Update() {
        if(Time.timeSinceLevelLoad >= delay && !activated) {
            int index = Random.Range(0, sadPhrase.Length);
            audio = GetComponent<AudioSource>();
            PlayClip(sadPhrase[index]);
            activated = true;
        }
    }
}
