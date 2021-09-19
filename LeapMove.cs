using UnityEngine;
using System.Collections;
using Leap;
using Leap.Unity;
using Leap.Unity.Attributes;


public class LeapMove : MonoBehaviour {
    public CapsuleHand leaphand;
    Controller controller;
    Vector3 originalPos;

    void Start ()
    {
        originalPos = leaphand.palm;
    }

    void moveForward (CapsuleHand lhand) {
        if (lhand.palm.z > originalPos.z && lhand.palm.x > originalPos.x) {
            this.transform.position += new Vector3(0.003f, 0.0f, 0.003f);
            originalPos = lhand.palm;

        }
        if (lhand.palm.z > originalPos.z && lhand.palm.x < originalPos.x) {
            this.transform.position += new Vector3(-0.003f, 0.0f, 0.003f);
            originalPos = lhand.palm;

        }
        if (lhand.palm.z < originalPos.z && lhand.palm.x > originalPos.x) {
            this.transform.position += new Vector3(0.003f, 0.0f, -0.003f);
            originalPos = lhand.palm;

        }
        if (lhand.palm.z < originalPos.z && lhand.palm.x < originalPos.x) {
            this.transform.position += new Vector3(-0.003f, 0.0f, -0.003f);
            originalPos = lhand.palm;
        }
        if (lhand.palm.z > originalPos.z) {
            this.transform.position += new Vector3(0.0f, 0.0f, 0.003f);
            originalPos = lhand.palm;
        }
        if (lhand.palm.z < originalPos.z) {
            this.transform.position += new Vector3(0.0f, 0.0f, -0.003f);
            originalPos = lhand.palm;
        }
        if (lhand.palm.x > originalPos.x) {
            this.transform.position += new Vector3(0.003f, 0.0f, 0.0f);
            originalPos = lhand.palm;
        }
        if (lhand.palm.x < originalPos.x) {
            this.transform.position += new Vector3(-0.003f, 0.0f, 0.0f);
            originalPos = lhand.palm;
        }
    }

    void Update ()
    {
        moveForward(leaphand);
        // Debug.Log(leaphand.palm);
        // Debug.Log("*********");
        // Debug.Log(originalPos.z);
        // originalPos = leaphand.transform.position;
        // do something with the tracking data in the frame...
    }
}