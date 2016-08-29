using UnityEngine;
using System.Collections;

[RequireComponent (typeof(Collider))]
public class LoseCondition : MonoBehaviour {

    void OnCollisionEnter(Collision col) {
        if (col.gameObject.GetComponent<Player>())
            FindObjectOfType<LevelManager>().LoadLevel(3);         
    }    
}