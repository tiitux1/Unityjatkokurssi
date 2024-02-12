using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    
       
    public Transform target; 
    public float smoothSpeed = 0.125f;

    public Vector3 offset; 

    void FixedUpdate()
    {
        
        Vector3 desiredPosition = new Vector3(target.position.x, transform.position.y, transform.position.z) + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}

