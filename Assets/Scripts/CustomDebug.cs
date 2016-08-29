using UnityEngine;
using System.Collections;

public class CustomDebug : MonoBehaviour {

    public float timeRate = 1; 
    public Trap spawnBoulder;
    public bool DestroyBoulders = true;
    //public bool light = false;

    private GameObject player;

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<Player>().gameObject;
        player.transform.position = transform.position;
        FindObjectOfType<GameManager>().StartGame();
        spawnBoulder.Activate();
        Time.timeScale = timeRate;
        //this.GetComponentInChildren<Light>().gameObject.SetActive(light);
	}

    void Update() {

        if (FindObjectOfType<Boulder>() && DestroyBoulders) { 
            GameObject boulder = FindObjectOfType<Boulder>().gameObject;
            Destroy(boulder);
            Destroy(this);
        }else if(!DestroyBoulders) {
            Destroy(this);
        }
    }
}
