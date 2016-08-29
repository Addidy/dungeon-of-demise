using UnityEngine;
using System.Collections;

public class CustomDebug : MonoBehaviour {

    public float timeRate = 1;
    public Trap spawnBoulder;
    public bool DestroyBoulders = true;

    private GameObject player;

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<Player>().gameObject;
        player.transform.position = transform.position;
        FindObjectOfType<GameManager>().StartGame();
        spawnBoulder.Activate();
        Time.timeScale = timeRate;

	}

    void Update() {
        print("destroy boulder" + DestroyBoulders);

            if (FindObjectOfType<Boulder>() && DestroyBoulders) { 
                GameObject boulder = FindObjectOfType<Boulder>().gameObject;
                Destroy(boulder);
            }
        }
}
