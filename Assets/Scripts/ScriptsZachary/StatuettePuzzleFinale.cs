using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class StatuettePuzzleFinale : MonoBehaviour
{
    [SerializeField] private GameObject _LevierA;
    [SerializeField] private GameObject _LevierB;
    [SerializeField] private GameObject _LevierC;

    [SerializeField] private GameObject _StatuetteA;
    [SerializeField] private GameObject _StatuetteB;
    [SerializeField] private GameObject _StatuetteC;

    [SerializeField] private Collider _MainsJoueur;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("MainJoueurDroite"))
        {
            Debug.Log("Allo");
        }
    }
}
