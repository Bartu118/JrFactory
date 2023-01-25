using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sayac : MonoBehaviour
{
    public Transform sayac; 
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    void Update()
    {
        Vector3 desiredPosition = sayac.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}