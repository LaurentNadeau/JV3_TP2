using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrouverStatue : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if(other.transform.tag == "Player"){
            SceneManager.LoadScene("menuFin");
        }
    }
}
