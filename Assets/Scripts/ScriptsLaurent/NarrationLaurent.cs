using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Narration : MonoBehaviour
{
    public bool narrationFait = false;
    public AudioSource narration;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && narrationFait == false)
        {
            narration.Play();
            narrationFait = true;      
        }
    }
}
