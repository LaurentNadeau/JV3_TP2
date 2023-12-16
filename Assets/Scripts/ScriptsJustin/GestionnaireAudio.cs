using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class GestionnaireAudio : MonoBehaviour
{
    [SerializeField] private AudioMixer _audioMixer;
    public void AjusterVolumeMusique(float valeur){
        _audioMixer.SetFloat("volumeMusique", valeur);
    }

    public void AjusterVolumeEffets(float valeur){
        _audioMixer.SetFloat("volumeEffets", valeur);
    }









    
}
