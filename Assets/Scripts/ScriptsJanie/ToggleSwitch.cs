using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleSwitch : MonoBehaviour
{
    [SerializeField]
    private GameObject on;

    [SerializeField]
    private GameObject off;

    private bool toggle;

    [SerializeField] private Animator door;

    private void onCollisionEnter(Collision other){
        if(other.transform.tag == "Player"){
            if(toggle == false){
            on.SetActive(true);
            off.SetActive(false);
            door.SetBool("IsOpen", true);
            toggle = true;
            }
        else{
            on.SetActive(false);
            off.SetActive(true);
            door.SetBool("IsOpen", false);
            toggle = false;
            }
        }
    }
}
