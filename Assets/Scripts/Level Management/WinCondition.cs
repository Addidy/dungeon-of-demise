using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Collider))]
public class WinCondition : MonoBehaviour {

    void OnTriggerEnter(Collider col) {
        if (col.gameObject.GetComponent<Player>())  //if you get to the end of the level
            FindObjectOfType<LevelManager>().LoadLevel(2);
    }
}
