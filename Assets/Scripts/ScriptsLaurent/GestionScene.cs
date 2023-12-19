using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestionScene : MonoBehaviour
{
    public void Perdu(){
        SceneManager.LoadScene("menuFin");
    }

    public void SceneSuivante(){
        int sceneSuivante = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(sceneSuivante);

    }
}
