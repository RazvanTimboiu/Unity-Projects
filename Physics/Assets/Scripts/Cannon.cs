using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public Rigidbody cannonballInstance;
    public float angle = 45f;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))                                    //At this moment we click 'leftclick' to fire the mortar.
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);    //The ray from the camera to the point where we clicked.

            RaycastHit hitInfo;
            if (Physics.Raycast(ray, out hitInfo))                          //If we clicked a valid object it becomes our target.
            {
                FireCannonAtTarget(hitInfo.point);                          //We shoot a mortar shell towards that target.
            }
        }
    }

    private void FireCannonAtTarget(Vector3 target)
    {
        var velocity = BallisticVelocity(target, angle);

        cannonballInstance.transform.position = transform.position;          // The shell starts in the middle of the mortar.
        cannonballInstance.velocity = velocity;                              // We set the shell speed and direction using the velocity attribute.
    }

    private Vector3 BallisticVelocity(Vector3 target, float angle)
    {
        Vector3 MortarPosition = transform.position;
        Vector3 TargetPosition  = target;
        Vector3 PositionDifference = TargetPosition - MortarPosition;         // The difference in coordinates between our target and the mortar.

        float HeightDifference = PositionDifference.y;                        // Height difference between the target and the mortar cannon.
        PositionDifference.y = 0;                                             // We only keep x and y differences (horizontal plane).
        float HorizontalDistance = PositionDifference.magnitude;              // Without y , we're left with the vector composed of x and z.

        Debug.Log("Plane distance from mortar to target: " + HorizontalDistance);
        Debug.Log("Mortar firing angle: " + angle);
        float MortarAngle = angle * Mathf.Deg2Rad;                               // We convert the angle to radians.

        PositionDifference.y = HorizontalDistance * Mathf.Tan(MortarAngle);      
        Debug.Log("Maximum reach(no gravity): " + PositionDifference.y); 

        HorizontalDistance += HeightDifference / Mathf.Tan(MortarAngle);         // Small correction for close targets.
        float g = Physics.gravity.magnitude;                                     // g = 9.81 -> gravitational acceleration.

        // Time to compute the velocity.
        float Velocity = Mathf.Sqrt(HorizontalDistance * g / Mathf.Sin(2 * MortarAngle));
        Debug.Log("Launch speed: " + Velocity);

        return Velocity * PositionDifference.normalized;                         //We normalize the speed vector.
    }
}
