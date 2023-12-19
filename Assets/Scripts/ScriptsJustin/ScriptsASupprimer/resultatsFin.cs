using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RésultatsFin : MonoBehaviour
{
    //[SerializeField] private PlayerStats health;

     


    [Header("ScriptableObject")]
    [SerializeField]
    private InfosJoueur _joueur;

     [SerializeField] private float _tempsRestant;


    [Header("ScriptableObject")]
    [SerializeField]
    private InfosNiveau _Jeu;
    [SerializeField] TMP_Text timeText;

     [SerializeField] private GestionnaireScenes _GestionScenes;

    [Space(10)]
    [Header("Nom du joueur")]
    [SerializeField]
    private TMP_Text _nomDuJoueur;
    [Space(10)]
    [Header("Nom du jeu")]
    [SerializeField]
    private TMP_Text _nomDuJeu;

     [Space(10)]
     [Header("Pointage")]
     [SerializeField] private TMP_Text _points;
     

     [SerializeField] private TMP_Text _pointsNegatifs;
     

    [SerializeField] private TMP_Text _pointsTotaux;
     

    // Start is called before the first frame update
    void Start()
    {
         _nomDuJoueur.text = _joueur.nomJoueur;
         _nomDuJeu.text = _Jeu.nomJeu;

    }

    // Update is called once per frame
    void Update()
    {
        AfficherPoints();
        CalculTemps();
    }

    void AfficherPoints(){
        _points.text = _joueur.nbPoints.ToString();
        _pointsNegatifs.text = _joueur.nbPointsNeg.ToString();
        _pointsTotaux.text = _joueur.total.ToString();


       /* if(_joueur.total >= _Jeu.nbPointsAFaire){
            _GestionScenes.SceneFin(); 
        }

        if( PlayerStats.Instance.Health == 0){
             _GestionScenes.SceneFin();
        }*/

        
    }

        void CalculTemps(){
        _tempsRestant-= Time.deltaTime;
        AfficheTemps(_tempsRestant);

    }

       void AfficheTemps(float tempsDeJeu){
        if(tempsDeJeu>0){
            tempsDeJeu+=1;

        float minutes = Mathf.FloorToInt(tempsDeJeu/60);
        float secondes = Mathf.FloorToInt(tempsDeJeu % 60);


        timeText.text = string.Format("{0:00}:{1:00}",minutes,secondes);

        }
        else{
           
      //  _GestionScenes.SceneFin();
        
        }
        
    }
}
