using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnHit : MonoBehaviour
{
    AudioSource audioData;
    private void OnTriggerEnter(Collider other)
    {
        audioData = GetComponent<AudioSource>();
        audioData.Play(0);
    }
}
