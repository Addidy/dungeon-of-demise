using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TakeMonkey : MonoBehaviour {

    public Text takeMonkey;
    public string buttonToPress = "Jump";

    private GameManager gameManager;


    void Start() {
        gameManager = FindObjectOfType<GameManager>();
        if (!takeMonkey || !gameManager) {
            print("Please set Text UI or GameManager");
        }
        takeMonkey.text = "W,A,S,D to move, move mouse to look around";
    }

    void OnTriggerEnter(Collider col) {
        if (col.gameObject.GetComponent<Player>() && gameManager.gameStarted == false) {
            takeMonkey.text = "Press space to museum the Idol";
        }
    }

    void OnTriggerStay(Collider col) {
        if (col.gameObject.GetComponent<Player>() && Input.GetButtonDown(buttonToPress) && gameManager.gameStarted == false) {
            gameManager.StartGame();
            takeMonkey.text = "";
            transform.parent.gameObject.SetActive(false);
        }
    }

    void OnTriggerExit(Collider col) {
        if (col.gameObject.GetComponent<Player>()) {
            takeMonkey.text = "";
        }
    }
}