using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateArmsZ : MonoBehaviour
{
    public GameObject RightElbow;
    public GameObject LeftElbow;
    public GameObject RightShoulder;
    public GameObject LeftShoulder;

    private float rotationZ = 0f;
    private float sensitivityZ = 2f;

    void Start()
    {

    }

    void Update()
    {
        rotationZ += Input.GetAxis("Mouse X") * sensitivityZ;

        RightElbow.transform.localEulerAngles = new Vector3(RightElbow.transform.localEulerAngles.x, RightElbow.transform.localEulerAngles.y, Mathf.Clamp(rotationZ, 0, 135));
        LeftElbow.transform.localEulerAngles = new Vector3(LeftElbow.transform.localEulerAngles.x, LeftElbow.transform.localEulerAngles.y, -Mathf.Clamp(rotationZ, 0, 135));

        RightShoulder.transform.localEulerAngles = new Vector3(RightShoulder.transform.localEulerAngles.x, RightShoulder.transform.localEulerAngles.y, Mathf.Clamp(rotationZ, -45, 45));
        LeftShoulder.transform.localEulerAngles = new Vector3(LeftShoulder.transform.localEulerAngles.x, LeftShoulder.transform.localEulerAngles.y, -Mathf.Clamp(rotationZ, -45, 45));


    }
}
