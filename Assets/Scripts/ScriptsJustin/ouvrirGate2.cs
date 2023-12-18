using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ouvrirGate2 : MonoBehaviour
{

     [SerializeField] private GameObject _gate;
   [SerializeField] private Animator _animatorGate;
    // Start is called before the first frame update
    void Start()
    {
        _animatorGate = _gate.GetComponent<Animator>();
        Debug.Log("Pris");
    }

    // Update is called once per frame
    void Update()
    {
        
    }



  public void OnTriggerEnter(Collider other) {
    
        _animatorGate.SetBool("ouvrirGate2", true);
    


     
        
    
  }
}
