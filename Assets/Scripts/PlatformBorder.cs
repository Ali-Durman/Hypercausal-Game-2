using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBorder : MonoBehaviour
{
    public float minX;
    public float maxX;
    public float minZ;
    public float maxZ;
    void Update()
    {
        float xPos = Mathf.Clamp(transform.position.x, minX, maxX);
        float zPos = Mathf.Clamp(transform.position.z, minZ, maxZ);
        transform.position = new Vector3(xPos, transform.position.y, zPos);
    }
}
