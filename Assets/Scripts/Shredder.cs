using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Collider))]
public class Shredder : MonoBehaviour {

    void OnTriggerEnter(Collider col) {
        print("shredder triggered");
        Destroy(col.gameObject);
    }
}
