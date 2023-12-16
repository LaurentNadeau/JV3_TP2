using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestionnaireScenes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SceneAutre(){
        SceneManager.LoadScene("ZoneDeJeu");
    }

    public void SceneFin(){
        SceneManager.LoadScene("FinDuJeu");
    }

    public void SceneFinGagnant(){
        SceneManager.LoadScene("FinDuJeuGagné");
    }
}
