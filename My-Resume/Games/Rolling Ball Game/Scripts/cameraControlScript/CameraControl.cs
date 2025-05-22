using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject Target;
    public float xOffset, yOffset, zOffset;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Target.transform.position + new Vector3(xOffset, yOffset, zOffset);
        transform.LookAt(Target.transform.position);
    }
}
