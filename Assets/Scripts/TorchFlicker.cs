using UnityEngine;
using System.Collections;

[RequireComponent (typeof(Light))]
public class TorchFlicker : MonoBehaviour {


    public float maxLight = 2f;
    public float minLight = 0.5f;

    private Light light;

	// Use this for initialization
	void Start () {
        light = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
        light.intensity = Mathf.Lerp(light.intensity, Random.Range(minLight, maxLight), 0.1f);
	}
}
