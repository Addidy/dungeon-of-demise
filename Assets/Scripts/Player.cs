using UnityEngine;
using System.Collections;

//[RequireComponent(typeof(Camera))]
[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour {

    public float speed = 100f;
    public float rotationSpeed = 1;

    private Camera playerSight;
    private Rigidbody rigidbody;
    private Animator anim;

    void Start() {
        rigidbody = GetComponent<Rigidbody>();
        playerSight = GetComponentInChildren<Camera>();
        anim = GetComponentInChildren<Animator>();
    }

    void FixedUpdate() {
        ControlPosition();
        ControlCamera();
    }

    private void ControlCamera() {
        float mouseX = Input.GetAxis("Mouse X") * rotationSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * rotationSpeed;
        playerSight.transform.rotation *= Quaternion.Euler(-mouseY, 0, 0);
        transform.rotation *= Quaternion.Euler(0, mouseX, 0);
    }


    private void ControlPosition() {
        bool animRun = anim.GetBool("isRunning");
        bool currentlyRunning = (Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0);
        if(currentlyRunning != animRun) {
            anim.SetBool("isRunning", currentlyRunning);
        }
            
        
        float movementForward = Input.GetAxis("Vertical");
        float movementStrafe = Input.GetAxis("Horizontal");
        Vector3 desiredMove = transform.forward * movementForward + transform.right * movementStrafe;
        desiredMove.x *= speed;
        desiredMove.z *= speed;
        desiredMove.y *= speed;

        rigidbody.velocity = desiredMove;
    }

    public void Slide() {
        CameraShake camShake = FindObjectOfType<CameraShake>();


    }
}