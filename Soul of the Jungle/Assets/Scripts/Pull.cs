using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pull : MonoBehaviour
{
    //Input from SteamVR
    public SteamVR_TrackedObject controller;
    //Previous position to update
    [HideInInspector]
    public Vector3 prevPos;
    //Can grab the rock
    [HideInInspector]
    public bool canGrip;
    

	//Initialize prevPos
	void Start ()
	{
	    prevPos = controller.transform.localPosition;
	}
	//Touching objects that can be gripped
	void OnTriggerEnter()
    {
        canGrip = true;
    }
    //Not touching objects that can be gripped
    void OnTriggerExit()
    {
        canGrip = false;
    }
}
