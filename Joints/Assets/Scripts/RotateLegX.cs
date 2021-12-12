using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLegX : MonoBehaviour
{
    public GameObject RightHip;
    public GameObject RightKnee;
    public GameObject RightAnkle;
    public GameObject LeftHip;
    public GameObject LeftKnee;
    public GameObject LeftAnkle;

    private float rotationX = 0f;
    private float sensitivityX = 2f;

    void Start()
    {
        
    }

    void Update()
    {
        rotationX += Input.GetAxis("Mouse X") * sensitivityX;

        RightHip.transform.localEulerAngles = new Vector3(Mathf.Clamp(rotationX, -75, 45), RightHip.transform.localEulerAngles.y, RightHip.transform.localEulerAngles.z);
        LeftHip.transform.localEulerAngles = new Vector3(Mathf.Clamp(rotationX, -75, 45), LeftHip.transform.localEulerAngles.y, LeftHip.transform.localEulerAngles.z);

        RightKnee.transform.localEulerAngles = new Vector3(Mathf.Clamp(rotationX, 0, 90), RightKnee.transform.localEulerAngles.y, RightKnee.transform.localEulerAngles.z);
        LeftKnee.transform.localEulerAngles = new Vector3(Mathf.Clamp(rotationX, 0, 90), LeftKnee.transform.localEulerAngles.y, LeftKnee.transform.localEulerAngles.z);

        RightAnkle.transform.localEulerAngles = new Vector3(Mathf.Clamp(rotationX, 0, 25), RightAnkle.transform.localEulerAngles.y, RightAnkle.transform.localEulerAngles.z);
        LeftAnkle.transform.localEulerAngles = new Vector3(Mathf.Clamp(rotationX, 0, 25), LeftAnkle.transform.localEulerAngles.y, LeftAnkle.transform.localEulerAngles.z);


    }
}
