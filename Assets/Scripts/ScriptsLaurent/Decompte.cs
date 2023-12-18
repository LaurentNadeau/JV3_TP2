using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Decompte : MonoBehaviour
{
    [SerializeField] private InfosNiveauTimer infosNiveauTimer;

    private bool decompteActif = false;

    public UnityEvent auChangementDuTemps;
    public UnityEvent aLaFinDuTemps;

    void Start()
    {
        DemarrerDecompte();
    }

    void Update()
    {
        if(decompteActif){
            if(infosNiveauTimer.temps > 0){
                infosNiveauTimer.temps -= Time.deltaTime;
                auChangementDuTemps.Invoke();
            }
            else{
                infosNiveauTimer.temps = 0;
                decompteActif = false;
                aLaFinDuTemps.Invoke();
            }
        }
    }
    public void DemarrerDecompte(){
        infosNiveauTimer.temps = infosNiveauTimer.tempsInitial;
        decompteActif = true;      
    }
}
