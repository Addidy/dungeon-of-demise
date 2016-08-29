using UnityEngine;
using System.Collections;

public class Dart : MonoBehaviour {

    public float speed = 10;
    private float lifeTime = 10f;
    private float startTime;


	// Use this for initialization
	void Start () {
        startTime = Time.timeSinceLevelLoad;
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.timeSinceLevelLoad >= (startTime + lifeTime)) {
            Destroy(gameObject);
        }
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
	}
}
