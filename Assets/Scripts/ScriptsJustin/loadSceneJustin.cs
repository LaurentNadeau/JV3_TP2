using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadSceneJustin : MonoBehaviour
{

    private levelManager _levelManager;
    // Start is called before the first frame update
    void Start()
    {
        _levelManager = levelManager.Instance;
    }

    // Update is called once per frame
  
   private void OnTriggerEnter(Collider other)
   {
        _levelManager.LoadAsyncScene(levelManager.Scene.niveau3);
   }
}
