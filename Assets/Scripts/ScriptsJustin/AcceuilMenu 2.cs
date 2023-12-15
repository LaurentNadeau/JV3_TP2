using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AcceuilMenu : MonoBehaviour
{

    [SerializeField] private TMP_InputField _ChampNomInput;
     [SerializeField] private TMP_InputField _ChampJeuInput;
    [SerializeField] private GestionnaireScenes _GestionScenes;
    [SerializeField] private InfosJoueur _infosJoueur;
    [SerializeField] private InfosNiveau _infosNiveau;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void PartJeu(){
        if(_ChampNomInput.text != "" && _ChampJeuInput.text!=""){
            _infosJoueur.nomJoueur = _ChampNomInput.text;
            _infosNiveau.nomJeu = _ChampJeuInput.text;
            _GestionScenes.SceneAutre();
        }
    }

    

}
