using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLegY : MonoBehaviour
{
    public GameObject RightHip;
    public GameObject LeftHip;

    private float rotationY = 0f;
    private float sensitivityY = 2f;

    void Start()
    {

    }

    void Update()
    {
        rotationY += Input.GetAxis("Mouse X") * sensitivityY;

        RightHip.transform.localEulerAngles = new Vector3(RightHip.transform.localEulerAngles.x, Mathf.Clamp(rotationY, -45, 45), RightHip.transform.localEulerAngles.z);
        LeftHip.transform.localEulerAngles = new Vector3(LeftHip.transform.localEulerAngles.x, -Mathf.Clamp(rotationY, -45, 45), LeftHip.transform.localEulerAngles.z);



    }
}
