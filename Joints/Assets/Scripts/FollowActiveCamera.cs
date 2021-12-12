using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowActiveCamera : MonoBehaviour
{
    void Start()
    {
        transform.LookAt(Camera.current.transform);
    }

    void Update()
    {
        transform.LookAt(Camera.current.transform);
    }
}
