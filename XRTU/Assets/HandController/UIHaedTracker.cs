using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIHaedTracker<vector3> : MonoBehaviour
{
    public Transform playerCamera;
    Vector3 lookAtPosition;

    // Update is called once per frame
    void Update()
    {
        if(playerCamera is not null)
        {
            lookAtPosition = new Vector3(playerCamera.position.x, playerCamera.position.y, playerCamera.position.z);
            
            transform.LookAt(lookAtPosition);

            transform.forward = -transform.forward;
        }
    }
}


