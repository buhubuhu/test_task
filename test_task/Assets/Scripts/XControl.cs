using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XControl : MonoBehaviour
{
    Vector3 StartPosition;
    Quaternion StartRotation;
    // Start is called before the first frame update
    void Start()
    {
        StartPosition = transform.position;
        StartRotation = transform.rotation;
    }

    public void ResetPosition()
    {
        transform.position = StartPosition;
        transform.rotation = StartRotation;
    }

    
}
