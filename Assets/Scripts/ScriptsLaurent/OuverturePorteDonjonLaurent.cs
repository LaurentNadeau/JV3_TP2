using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuverturePorteDonjonLaurent : MonoBehaviour
{
    public AudioSource audioOuverture;
    public AudioClip serrure;
    public AudioClip porte;
    [SerializeField] private Animator cleTourne;
    [SerializeField] private Animator porteOuvre;

    public void SequenceOuverturePorte(){
        cleTourne.SetBool("clePrete", true);
        audioOuverture.clip = serrure;
        audioOuverture.Play();
        Invoke("OuvrirPorte", 1.0f);
    }
    public void OuvrirPorte(){
        porteOuvre.SetBool("portePrete", true);
        audioOuverture.clip = porte;
        audioOuverture.Play();
    }
}
