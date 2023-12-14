using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ChangementDeScèneLaurent : MonoBehaviour
{
    public UnityEvent changerScene;
    
    public void OnTriggerEnter(Collider other){
        Debug.Log(other);

        if(other.CompareTag("Player")){
            changerScene.Invoke();
            Debug.Log("Chagement de scene appele");
        }
    }
}
