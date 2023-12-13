using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private Animator couvercle;

    public AudioSource audioCouvercle;
    public AudioClip sonFermerCouvercle;
    public AudioClip sonOuvrirCouvercle;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            couvercle.SetBool("estOuvert", true);
            audioCouvercle.clip = sonOuvrirCouvercle;
            audioCouvercle.Play();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            couvercle.SetBool("estOuvert", false);
            audioCouvercle.clip = sonFermerCouvercle;
            audioCouvercle.Play();
        }
    }
}
