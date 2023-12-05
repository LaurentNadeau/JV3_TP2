using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{


        // Start is called before the first frame update
    void Start()
    {
        
    }

   public void DebutDeLaPartie()
{
	SceneManager.LoadScene("ZoneDeJeu");
}

public void QuitterApplication()
{
	Debug.Log("Quitter le Jeu");
	Application.Quit();
}


}
