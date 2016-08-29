using UnityEngine;
using System.Collections;

public class BoulderSpin : MonoBehaviour {

    public float rotSpeed = 1f;
	
	// Update is called once per frame
	void Update () {
        transform.rotation *= Quaternion.Euler(rotSpeed * Time.deltaTime,0, 0);
	}
}
