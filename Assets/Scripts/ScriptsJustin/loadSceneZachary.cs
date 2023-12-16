using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadSceneZachary : MonoBehaviour
{
    // Start is called before the first frame update
  
    private levelManager _levelManager;
    // Start is called before the first frame update
    void Start()
    {
        _levelManager = levelManager.Instance;
    }

    // Update is called once per frame
  
   private void OnTriggerEnter(Collider other)
   {
        _levelManager.LoadAsyncScene(levelManager.Scene.SceneZachary);
   }
}
