using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private Animator couvercle;

    public bool narrationFait = false;
    public AudioSource audioCouvercle;
    public AudioSource narration;
    public AudioClip sonFermerCouvercle;
    public AudioClip sonOuvrirCouvercle;
    
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            couvercle.SetBool("estOuvert", true);
            audioCouvercle.clip = sonOuvrirCouvercle;
            audioCouvercle.Play();
            if(narrationFait == false){
                narration.Play();
                narrationFait = true;
            }
        }
    }
        
    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            couvercle.SetBool("estOuvert", false);
            audioCouvercle.clip = sonFermerCouvercle;
            audioCouvercle.Play();
        }
    }
}
