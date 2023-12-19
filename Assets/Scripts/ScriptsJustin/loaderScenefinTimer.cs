using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class loaderScenefinTimer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   public void LoadMainMenu(){
        SceneManager.LoadScene(Scene.menuFin.ToString());
    }

     public enum Scene{
    

        menuFin,

     
    }
}
