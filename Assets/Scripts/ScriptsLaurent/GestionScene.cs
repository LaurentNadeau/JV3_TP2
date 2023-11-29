using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestionScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SceneSuivante(){
        int sceneSuivante = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(sceneSuivante);

    }
}
