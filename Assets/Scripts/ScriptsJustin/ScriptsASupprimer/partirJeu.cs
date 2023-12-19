using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class partirJeu : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void partirLeJeu(){
        SceneManager.LoadScene("ScenePrincipale");
    }


   
}

