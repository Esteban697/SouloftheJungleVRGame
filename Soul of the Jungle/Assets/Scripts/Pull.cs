using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pull : MonoBehaviour
{

    public SteamVR_TrackedObject controller;

    public float jumpForce = 1.2f;

    [HideInInspector]
    public Vector3 prevPos;

    [HideInInspector]
    public bool canGrip;

	// Use this for initialization
	void Start ()
	{
	    prevPos = controller.transform.localPosition;
	}
	//Touching objects that can be gripped
	void OnTriggerEnter()
    {
        canGrip = true;
    }

    void OnTriggerExit()
    {
        canGrip = false;
    }
}
