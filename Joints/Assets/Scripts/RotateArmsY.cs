using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateArmsY : MonoBehaviour
{
    public GameObject RightElbow;
    public GameObject LeftElbow;
    public GameObject RightShoulder;
    public GameObject LeftShoulder;

    private float rotationY = 0f;
    private float sensitivityY = 2f;

    void Start()
    {
        
    }


    void Update()
    {
        rotationY += Input.GetAxis("Mouse Y") * sensitivityY;

        RightElbow.transform.localEulerAngles = new Vector3(RightElbow.transform.localEulerAngles.x, Mathf.Clamp(rotationY, -45, 0), RightElbow.transform.localEulerAngles.z);
        LeftElbow.transform.localEulerAngles = new Vector3(LeftElbow.transform.localEulerAngles.x, -Mathf.Clamp(rotationY, -45, 0), LeftElbow.transform.localEulerAngles.z);

        RightShoulder.transform.localEulerAngles = new Vector3(RightShoulder.transform.localEulerAngles.x, Mathf.Clamp(rotationY, -90, 25), RightShoulder.transform.localEulerAngles.z);
        LeftShoulder.transform.localEulerAngles = new Vector3(LeftShoulder.transform.localEulerAngles.x, -Mathf.Clamp(rotationY, -90, 25), LeftShoulder.transform.localEulerAngles.z);
    }
}
