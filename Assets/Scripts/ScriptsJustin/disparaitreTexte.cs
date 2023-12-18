using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class disparaitreTexte : MonoBehaviour
{

   [SerializeField] private GameObject canvas;
    // Start is called before the first frame update
 private void OnTriggerEnter(Collider other)
   {
        canvas.SetActive(false);
   }
}
