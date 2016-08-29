using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
    public StoneDoor door;

    [HideInInspector]
    public bool gameStarted = false;

	// Use this for initialization
	void Start () {
        if (!door)
            print("Check game master for missing door x Adam");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void StartGame() {
        print("Game Started");
        gameStarted = true;
        door.Activate();
    }
}
