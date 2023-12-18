using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activationLeviers : MonoBehaviour
{

        
    
   
    // Start is called before the first frame update
    [SerializeField] private GameObject _levier;
   [SerializeField] private Animator _animatorLevier;
    // Start is called before the first frame update
    void Start()
    {
        _animatorLevier = _levier.GetComponent<Animator>();
        Debug.Log("Pris");
    }

    // Update is called once per frame
    void Update()
    {
        
    }



  public void OnTriggerEnter(Collider other) {
    
        _animatorLevier.SetBool("activation", true);
    


     
        
    
  }

   
}


