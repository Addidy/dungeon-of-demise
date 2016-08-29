using UnityEngine;
using System.Collections;

public class ToggleCursor : MonoBehaviour {

	// Use this for initialization
	void Start () {
        LockCursor();
	}

    void Update() {
        if (Input.GetButtonDown("Fire1"))
            LockCursor();
        if (Input.GetKeyDown(KeyCode.Escape))
            FreeCursor();
    }
	
	// Update is called once per frame
	public void LockCursor() {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void FreeCursor() {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
