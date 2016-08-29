using UnityEngine;
using System.Collections;
[RequireComponent (typeof (LevelManager))]
public class PressToContinue : MonoBehaviour {

    public string buttonToContinue = "Jump";
    public int nextSceneBuildIndex = 1;

    private LevelManager levelManager;


	// Use this for initialization
	void Start () {
        levelManager = FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetButtonDown(buttonToContinue)) {
            levelManager.LoadLevel(nextSceneBuildIndex);
        }
	}
}
