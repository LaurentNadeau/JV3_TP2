using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class loadSceneJustin : MonoBehaviour
{

    public void LoadMainMenu(){
        SceneManager.LoadScene(Scene.niveau3.ToString());
    }

     public enum Scene{
    

        niveau3,

     
    }
}
