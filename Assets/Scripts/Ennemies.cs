using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemies : MonoBehaviour
{
    public float dmg;
    [SerializeField] private HealthBarHUDTester _PerdreVie;
    [SerializeField] GameObject _PerdreLaVie;
     [SerializeField] InfosJoueur _Joueur;

     [SerializeField] private int _valeur = -3;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

      void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Player"){
            _Joueur.nbPointsNeg += 3;
            _Joueur.total = _Joueur.nbPoints - _Joueur.nbPointsNeg;
            PlayerStats.Instance.TakeDamage(dmg);
           Debug.Log("Aye");
        }
        
    }

}
