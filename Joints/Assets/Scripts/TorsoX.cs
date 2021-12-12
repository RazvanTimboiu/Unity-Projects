using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorsoX : MonoBehaviour
{
    public GameObject LowerSpine;
    public GameObject MiddleSpine;

    private float rotationX = 0f;
    private float sensitivityX = 2f;


    void Start()
    {
        
    }

    
    void Update()
    {
        rotationX += Input.GetAxis("Mouse Y") * sensitivityX;

        LowerSpine.transform.localEulerAngles = new Vector3(Mathf.Clamp(-rotationX, -25, 90), LowerSpine.transform.position.y - 10, LowerSpine.transform.position.z + 5f );
        MiddleSpine.transform.localEulerAngles = new Vector3(Mathf.Clamp(-rotationX, -25, 25), MiddleSpine.transform.position.y - 12.5f, MiddleSpine.transform.position.z + 2.5f);

    }
}
