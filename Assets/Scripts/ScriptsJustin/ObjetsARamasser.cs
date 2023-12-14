using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetsARamasser : MonoBehaviour
{
    [SerializeField] InfosJoueur _Joueur;
    [SerializeField] private int _valeur;









    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


     private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Player"){
            if(_valeur>0){
                _Joueur.nbPoints+=_valeur;
                Destroy(gameObject);
            }

            else{
                _Joueur.nbPointsNeg += _valeur;
            }

            _Joueur.total = _Joueur.nbPoints - _Joueur.nbPointsNeg;

        }
        
    }

















}
