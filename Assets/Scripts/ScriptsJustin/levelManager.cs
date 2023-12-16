using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class levelManager : MonoBehaviour
{
    [SerializeField] private GameObject _loaderCanvas;
    [SerializeField] private Image _progressBar;
    public static levelManager Instance;


    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    private void Awake()
    {
        if(Instance==null){
            Instance =this;
            DontDestroyOnLoad(gameObject);
        }
        else{
            Destroy(gameObject);
        }
    }

   public void LoadScene(Scene sceneName){
        SceneManager.LoadScene(sceneName.ToString());
   }

    public void LoadNewGame(){
        SceneManager.LoadScene(Scene.SceneLaurent.ToString());
    }


    public void LoadMainMenu(){
        SceneManager.LoadScene(Scene.menuAccueil.ToString());
    }

    public async void LoadAsyncScene(Scene sceneName){
        var sceneLoad = SceneManager.LoadSceneAsync(sceneName.ToString());
        sceneLoad.allowSceneActivation = false;
        _loaderCanvas.SetActive(true);

        do{
            await Task.Delay(100);
            _progressBar.fillAmount = sceneLoad.progress;
        } while(sceneLoad.progress < 0.9f);

        sceneLoad.allowSceneActivation = true;
        _loaderCanvas.SetActive(false);
    }


    public void QuitGame(){
        Application.Quit();
    }

 public enum Scene{
        menuAccueil,
        SceneLaurent,
        SceneJanie,

        niveau3,

        SceneZachary,

        menuFin,

        ScenePrincipale,

        ZoneDeJeu,
    }

}
