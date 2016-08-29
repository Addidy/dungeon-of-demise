using UnityEngine;
using System.Collections;

public class CameraShake : MonoBehaviour {

    public bool shakeEnabled = true;
    public float shakeLimit = 1;
    //[Range(0,1)]
    //public float shakeStrength = 1;
    [Range(0,1)]
    public float returnStrength = 0.5f;
    public float maxDistance = 30;
    public float slideOffset = -0.5f;
    [HideInInspector]
    public bool isSliding = false;

    private Vector3 restPosition;
    private BoulderDistanceFromPlayer bdfp;

	// Use this for initialization
	void Start () {
        restPosition = transform.localPosition;
        bdfp = FindObjectOfType<BoulderDistanceFromPlayer>();
        isSliding = false;
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 targetPosition = restPosition;
        if (isSliding) {
            targetPosition = restPosition + new Vector3(0, slideOffset, 0);
        }
        ReturnToPosition(targetPosition);
        float distance = bdfp.distance;
        if (distance > maxDistance) {
            return;
        } else if (shakeEnabled){
            float strength = (maxDistance - distance) / (maxDistance / shakeLimit);
            float zOffset = Random.Range(-strength, strength);
            float yOffset = Random.Range(-strength, strength);

            transform.localPosition = new Vector3(restPosition.x, restPosition.y + yOffset, restPosition.z + zOffset);
        }
    }

    private void ReturnToPosition(Vector3 position) {
        float yReturn = Mathf.Lerp(transform.localPosition.y, position.y, returnStrength);
        float zReturn = Mathf.Lerp(transform.localPosition.z, position.z, returnStrength);
        transform.localPosition = new Vector3(restPosition.x, yReturn, zReturn);
    }
}
