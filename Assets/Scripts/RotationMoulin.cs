using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationMoulin : MonoBehaviour
{
    [Space(5)]
    [SerializeField] private float _vitesse = 2;        // vitesse pour tourner sans rigidbody
    [SerializeField] Vector3 _valeurRotationEnContinue; 
   [SerializeField] private GameObject _Moulin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bougerObject();
    }

    void bougerObject(){
       
        _Moulin.transform.Rotate( _valeurRotationEnContinue * _vitesse * Time.deltaTime);

    }



}
