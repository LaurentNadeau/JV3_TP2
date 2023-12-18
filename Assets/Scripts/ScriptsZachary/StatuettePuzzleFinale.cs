using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class StatuettePuzzleFinale : MonoBehaviour
{
    /*[SerializeField] private GameObject _LevierA;*/
    /*[SerializeField] private GameObject _LevierB;*/
    /*[SerializeField] private GameObject _LevierC;*/
    /*[SerializeField] private Collider _MainsJoueur;*/

    //[Header("Mettre les statuettes de l'inventaire du joueur ici.")]
    //[SerializeField] private GameObject _statuetteDansInventaire1;
    //[SerializeField] private GameObject _statuetteDansInventaire2;
    //[SerializeField] private GameObject _statuetteDansInventaire3;

    [Header("Statuettes XR interactible.")]
    [Space(5)]

    [SerializeField] private GameObject _statuetteA;
    [SerializeField] private GameObject _statuetteB;
    [SerializeField] private GameObject _statuetteC;

    [Header("Trigger (Socket) pour tenir la statuette.")]
    [Space(5)]

    [SerializeField] private GameObject _statuetteASocket;
    [SerializeField] private GameObject _statuetteBSocket;
    [SerializeField] private GameObject _statuetteCSocket;

    [Header("Rondelles d'activation avant déclenchent.")]
    [Space(2)]
    [SerializeField] private GameObject _RondelleActivationA;
    [SerializeField] private GameObject _RondelleActivationB;
    [SerializeField] private GameObject _RondelleActivationC;



    [Header("Les statuettes gelé pour après l'activation de leur sockets.")]
    [Space(5)]

    [SerializeField] private GameObject _statuetteADansActivateur;
    [SerializeField] private GameObject _statuetteBDansActivateur;
    [SerializeField] private GameObject _statuetteCDansActivateur;


    [Header("Qu'elle statuette est active dans la machine.")]
    [Space(5)]

    [SerializeField] private bool _statuetteAActive = false;

    [SerializeField] private bool _statuetteBActive = false;

    [SerializeField] private bool _statuetteCActive = false;


    [Header("Animator pour les sockets.")]
    [Space(5)]

    [SerializeField] private Animator _statuetteAAnimator;
    [SerializeField] private Animator _statuetteBAnimator;
    [SerializeField] private Animator _statuetteCAnimator;

    [Header("Puzzle complet pour l'animation finale.")]
    [Space(5)]

    [SerializeField] private GameObject _statuetteActivateurComplet;
    [SerializeField] private Animator _statuetteActivateurCompletAnimator;

    void Start()
    {
        _statuetteA = GameObject.FindWithTag("Statuette 1");
        _statuetteB = GameObject.FindWithTag("Statuette 2");
        _statuetteC = GameObject.FindWithTag("Statuette 3");
    }

    // Update is called once per frame
    void Update()
    {
        PuzzleStatuetteVerification();
    }

    public void StatuetteAActif()
    {
        _statuetteAActive = true;
    }

    public void StatuetteBActif()
    {
        _statuetteBActive = true;
    }

    public void StatuetteCActif()
    {
        _statuetteCActive = true;
    }

    private void PuzzleStatuetteVerification()
    {
        if(_statuetteAActive == true)
        {
            StatuetteAPlace();

            if(_statuetteAActive == true && _statuetteBActive == true && _statuetteCActive == true)
            {
                _statuetteActivateurCompletAnimator.SetBool("PuzzleTermine", true);
            }
        }

        if(_statuetteBActive == true)
        {
            StatuetteBPlace();

            if(_statuetteAActive == true && _statuetteBActive == true && _statuetteCActive == true)
            {
                _statuetteActivateurCompletAnimator.SetBool("PuzzleTermine", true);
            }
        }

        if(_statuetteCActive == true)
        {
            StatuetteCPlace();

            if(_statuetteAActive == true && _statuetteBActive == true && _statuetteCActive == true)
            {
                _statuetteActivateurCompletAnimator.SetBool("PuzzleTermine", true);
            }
        }

    }

    private void StatuetteAPlace()
    {
        _RondelleActivationA.SetActive(false);
        _statuetteASocket.SetActive(false);
        _statuetteAAnimator.SetBool("degageA", true);

        _statuetteA.SetActive(false);


        _statuetteADansActivateur.SetActive(true);
    }

    private void StatuetteBPlace()
    {
        _RondelleActivationB.SetActive(false);
        _statuetteBSocket.SetActive(false);
        _statuetteBAnimator.SetBool("degageB", true);

        _statuetteB.SetActive(false);

        _statuetteBDansActivateur.SetActive(true);
    }

    private void StatuetteCPlace()
    {
        _RondelleActivationC.SetActive(false);
        _statuetteCSocket.SetActive(false);
        _statuetteCAnimator.SetBool("degageC", true);

        _statuetteC.SetActive(false);

        _statuetteCDansActivateur.SetActive(true);
    }

}
