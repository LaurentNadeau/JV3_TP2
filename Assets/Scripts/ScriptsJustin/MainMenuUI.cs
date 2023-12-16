using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MainMenuUI : MonoBehaviour
{
    // Start is called before the first frame update
   
    [SerializeField] Button _newGame;
    [SerializeField] Button _quitGame;


    private levelManager _levelmanager;
    // Start is called before the first frame update
    void Start()
    {
        _levelmanager = levelManager.Instance;
        _newGame.onClick.AddListener(StartNewGame);
        _quitGame.onClick.AddListener(QuitGame);
    }

    private void StartNewGame(){
        //_levelmanager.LoadNewGame();
        _levelmanager.LoadAsyncScene(levelManager.Scene.SceneLaurent);
    }
    // Update is called once per frame
   private void QuitGame(){
        Application.Quit();
   }

}
