using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorsoY : MonoBehaviour
{
    public GameObject LowerSpine;
    public GameObject MiddleSpine;

    private float rotationY = 0f;
    private float sensitivityY = 2f;


    void Start()
    {

    }


    void Update()
    {
        rotationY += Input.GetAxis("Mouse X") * sensitivityY;

        LowerSpine.transform.localEulerAngles = new Vector3(LowerSpine.transform.position.x, Mathf.Clamp(rotationY, -25, 25), LowerSpine.transform.position.z + 2.5f);
        MiddleSpine.transform.localEulerAngles = new Vector3(MiddleSpine.transform.position.x, Mathf.Clamp(rotationY, -25, 25), MiddleSpine.transform.position.z + 5);

    }
}
