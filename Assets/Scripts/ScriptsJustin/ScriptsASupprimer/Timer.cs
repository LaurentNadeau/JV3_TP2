/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Timer : MonoBehaviour
{
    [SerializeField] TMP_Text timeText;

    [SerializeField] InfosNiveau _tempsNiveau;

    [SerializeField] private GestionnaireScenes _GestionScenes;

    [SerializeField] private float _tempsRestant;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CalculTemps();
    }




    void CalculTemps(){
        _tempsNiveau-= Time.deltaTime;
        AfficheTemps(_tempsNiveau);
       

    }

    void AfficheTemps(float temps){
        temps+=1;

        float minutes = Mathf.FloorToInt(temps/60);
        float secondes = Mathf.FloorToInt(temps % 60);


        timeText.text = string.Format("{0:00}:{1:00}",minutes,secondes);


    }

    



}*/
