using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateRobot : MonoBehaviour
{
    public GameObject target;

    void Start()
    {

    }

    void Update()
    {

        transform.LookAt(target.transform.position);
        transform.RotateAround(target.transform.position, Vector3.up, 25 * Time.deltaTime);

    }
}
