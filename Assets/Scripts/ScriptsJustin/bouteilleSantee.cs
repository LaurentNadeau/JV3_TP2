using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bouteilleSantee : MonoBehaviour
{
     public float health;
     
    [SerializeField] private HealthBarHUDTester _GagnerVie;
    [SerializeField] GameObject _GagnerLaVie;
     [SerializeField] InfosJoueur _Joueur;

     

    [SerializeField] private GameObject _Bouteille;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }



     void OnTriggerEnter(Collider other){
        _Joueur.nbPoints += 1;
            _Joueur.total = _Joueur.nbPoints - _Joueur.nbPointsNeg;
     
     PlayerStats.Instance.Heal(health);
      

     }
}
