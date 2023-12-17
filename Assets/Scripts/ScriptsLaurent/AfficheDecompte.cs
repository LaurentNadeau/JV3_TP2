using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;

public class AfficheDecompte : MonoBehaviour
{
    [SerializeField] private InfosNiveauTimer infosNiveauTimer;
    [SerializeField] private TMP_Text champTexteTemps;

    public void AfficheTemps(){
        float temps = infosNiveauTimer.temps;
        if(temps < 0){
            temps = 0;
        }
        TimeSpan ts = TimeSpan.FromSeconds(temps);
        
        champTexteTemps.text = string.Format("{0:00}:{1:00}:{2:00}:{3:000}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
    }

}
