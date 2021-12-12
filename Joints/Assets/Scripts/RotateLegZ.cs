using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLegZ : MonoBehaviour
{
    public GameObject RightHip;
    public GameObject LeftHip;

    private float rotationZ = 0f;
    private float sensitivityZ = 2f;

    void Start()
    {

    }

    void Update()
    {
        rotationZ += Input.GetAxis("Mouse Y") * sensitivityZ;

        RightHip.transform.localEulerAngles = new Vector3(RightHip.transform.localEulerAngles.x, RightHip.transform.localEulerAngles.y, -Mathf.Clamp(rotationZ, -60, 0));
        LeftHip.transform.localEulerAngles = new Vector3(LeftHip.transform.localEulerAngles.x, RightHip.transform.localEulerAngles.y, Mathf.Clamp(rotationZ, -60, 0));
    }
}
