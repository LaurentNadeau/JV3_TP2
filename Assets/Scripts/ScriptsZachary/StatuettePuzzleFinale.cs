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

    [SerializeField] private GameObject _statuetteASocket;
    [SerializeField] private GameObject _statuetteBSocket;
    [SerializeField] private GameObject _statuetteCSocket;
    [SerializeField] private GameObject _RondelleActivationA;
    [SerializeField] private GameObject _RondelleActivationB;
    [SerializeField] private GameObject _RondelleActivationC;

    [SerializeField] private GameObject _statuetteADansActivateur;
    [SerializeField] private GameObject _statuetteBDansActivateur;
    [SerializeField] private GameObject _statuetteCDansActivateur;

    [SerializeField] private bool _statuetteAActive = false;

    [SerializeField] private bool _statuetteBActive = false;

    [SerializeField] private bool _statuetteCActive = false;

    /*[SerializeField] private Animator _statuetteAAnimator;
    [SerializeField] private Animator _statuetteBAnimator;
    [SerializeField] private Animator _statuetteCAnimator;*/

    [SerializeField] private GameObject _statuetteActivateurComplet;
    [SerializeField] private Animator _statuetteActivateurCompletAnimator;

    // Update is called once per frame
    void Update()
    {

    }

    private void StatuetteAActif()
    {
        _statuetteAActive = true;
    }

    private void StatuetteBActif()
    {
        _statuetteBActive = true;
    }

    private void StatuetteCActif()
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
        _statuetteADansActivateur.SetActive(true);
    }

    private void StatuetteBPlace()
    {
        _RondelleActivationB.SetActive(false);
        _statuetteBSocket.SetActive(false);
        _statuetteBDansActivateur.SetActive(true);
    }

    private void StatuetteCPlace()
    {
        _RondelleActivationC.SetActive(false);
        _statuetteCSocket.SetActive(false);
        _statuetteCDansActivateur.SetActive(true);
    }

}
