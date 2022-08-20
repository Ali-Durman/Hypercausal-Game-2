using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform target;
    public float smoothsSpeed = 0.125f;
    public Vector3 offset;

    void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smootedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothsSpeed);
        transform.position = smootedPosition;
    }
}
