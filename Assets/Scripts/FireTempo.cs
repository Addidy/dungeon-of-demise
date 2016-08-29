using UnityEngine;
using System.Collections;

public class FireTempo : MonoBehaviour {

    public float fireRate = 1f;        //set time between firing
    public float lastFired = -100000f;  //keeps track of when last fire occured       

    public FireTempo(float rate) {      //constructor
        fireRate = rate;
    }

    public bool Fire() {
        if (lastFired + fireRate <= Time.timeSinceLevelLoad) {  //Check if timer allows another fire
            lastFired = Time.timeSinceLevelLoad;                //set current time as last fired
            return true;                                        //return true to enable requester script to fire
        }
        return false;                                           //prevent fire
    }
}