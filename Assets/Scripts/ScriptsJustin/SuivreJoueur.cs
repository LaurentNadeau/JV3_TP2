using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SuivreJoueur : MonoBehaviour
{

    [SerializeField] GameObject _laCible;
    [SerializeField] private NavMeshAgent _agent;

    private Vector3 _positionDeLaCible;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BougerAgent();
    }





    void BougerAgent(){
        _positionDeLaCible = _laCible.transform.position;
        
        _agent.SetDestination(_positionDeLaCible);
    }






}



