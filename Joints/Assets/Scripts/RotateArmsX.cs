using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateArmsX : MonoBehaviour
{
    public GameObject RightElbow;
    public GameObject LeftElbow;
    public GameObject RightShoulder;
    public GameObject LeftShoulder;

    private float rotationX = 0f;
    private float sensitivityX = 2f;
    void Start()
    {
        
    }

    
    void Update()
    {
        rotationX += (Input.GetAxis("Mouse Y") + Input.GetAxis("Mouse X")) / 2 * sensitivityX;

        RightElbow.transform.localEulerAngles = new Vector3(Mathf.Clamp(rotationX, -45, 45), RightElbow.transform.localEulerAngles.y, RightElbow.transform.localEulerAngles.z);
        LeftElbow.transform.localEulerAngles = new Vector3(Mathf.Clamp(rotationX, -45, 45), LeftElbow.transform.localEulerAngles.y, LeftElbow.transform.localEulerAngles.z);

        RightShoulder.transform.localEulerAngles = new Vector3(Mathf.Clamp(rotationX, -90, 90), RightShoulder.transform.localEulerAngles.y, RightShoulder.transform.localEulerAngles.z);
        LeftShoulder.transform.localEulerAngles = new Vector3(Mathf.Clamp(rotationX, -90, 90), LeftShoulder.transform.localEulerAngles.y, LeftShoulder.transform.localEulerAngles.z);
    }
}
