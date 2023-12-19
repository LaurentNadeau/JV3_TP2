using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class loadSceneZacharyMenuUi : MonoBehaviour
{
    // Start is called before the first frame update    void Start()
      public void LoadMainMenu(){
        SceneManager.LoadScene(Scene.SceneZachary.ToString());
    }

     public enum Scene{
    

        SceneZachary,

     
    }
}
