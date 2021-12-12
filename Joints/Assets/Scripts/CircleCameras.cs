using UnityEngine;
using System.Collections;

public class CircleCameras : MonoBehaviour
{
    public Camera[] cameras;
    private int cameraIndex;

    void Start()
    {
        cameraIndex = 0;

        for (int i = 1; i < cameras.Length; i++)
        {
            cameras[i].gameObject.SetActive(false);
        }

        if (cameras.Length > 0)
        {
            cameras[cameraIndex].gameObject.SetActive(true);
        }
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.C))
        {
            cameraIndex++;

            if (cameraIndex < cameras.Length)
            {
                cameras[cameraIndex - 1].gameObject.SetActive(false);
                cameras[cameraIndex].gameObject.SetActive(true);
            }
            else
            {
                cameras[cameraIndex - 1].gameObject.SetActive(false);
                cameraIndex = 0;
                cameras[cameraIndex].gameObject.SetActive(true);
            }
        }
    }
}