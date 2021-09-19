using UnityEngine;
using System.Collections;
using Leap;
using Leap.Unity;
using Leap.Unity.Attributes;


public class LeapLeft : MonoBehaviour {
    public CapsuleHand leaphand;
    Controller controller;
    Vector3 originalPos;

    void Start ()
    {
        originalPos = leaphand.palm;
    }

    void moveForward (CapsuleHand lhand) {
        if (lhand.palm.x < originalPos.x) {
            Vector3 newPos = new Vector3(0, 0.3f, 0);
            this.transform.Rotate(newPos);
        }
        // else if (lhand.palm.x < originalPos.x) {
        //     Vector3 newPos = new Vector3(0, -0.3f, 0);
        //     this.transform.Rotate(newPos);
        // }
    }

    void Update ()
    {
        moveForward(leaphand);
        leaphand.palm = originalPos;
        // Debug.Log(leaphand.palm);
        // Debug.Log("*********");
        // Debug.Log(originalPos.z);
        // originalPos = leaphand.transform.position;
        // do something with the tracking data in the frame...
    }
}