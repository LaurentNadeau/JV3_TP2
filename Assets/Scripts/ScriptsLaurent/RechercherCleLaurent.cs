using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RechercherCleLaurent : MonoBehaviour
{
    [SerializeField] public GameObject zoneCle; 

    public void OnTriggerEnter(Collider other){
        if(other.CompareTag("Player")){
            zoneCle.SetActive(true);
        }
    }
}
