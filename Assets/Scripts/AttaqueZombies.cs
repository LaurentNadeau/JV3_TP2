using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttaqueZombies : MonoBehaviour
{
    public float dmg;
    [SerializeField] private HealthBarHUDTester _PerdreVie;
    [SerializeField] GameObject _PerdreLaVie;
     [SerializeField] InfosJoueur _Joueur;

     [SerializeField] private int _valeur = -3;

    [SerializeField] private GameObject _zombie;
    private Animator _animatorZombie;
    // Start is called before the first frame update
    void Start()
    {
        _animatorZombie = _zombie.GetComponent<Animator>();
        Debug.Log("Pris");
    }

    // Update is called once per frame
    void Update()
    {
        
    }



     void OnTriggerEnter(Collider other){
    _animatorZombie.SetBool("Attaque",true);
     _Joueur.nbPointsNeg += 2;
            _Joueur.total = _Joueur.nbPoints - _Joueur.nbPointsNeg;
            PlayerStats.Instance.TakeDamage(dmg);
           Debug.Log("Aye");
    Debug.Log("okah");

     }

    void OnTriggerExit(Collider other){
    _animatorZombie.SetBool("Attaque",false);
    Debug.Log("ok");
    }
}
