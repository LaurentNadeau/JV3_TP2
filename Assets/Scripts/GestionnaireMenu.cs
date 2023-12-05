using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GestionnaireMenu : MonoBehaviour
{
     [SerializeField] private bool _onOuOff;
    [SerializeField] private GameObject _PanneauSon;


    void OnMenu(InputValue value){
        if(_onOuOff){
            _onOuOff = false;
            _PanneauSon.SetActive(false);
        }

        else{
            _onOuOff = true;
            _PanneauSon.SetActive(true);
        }
    }
}
