using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="InfosJoueur",menuName="SO/NouveauJoueur")]
public class InfosJoueur : ScriptableObject
{
    // Start is called before the first frame update
    public string nomJoueur;
     public int nbPoints;
    public int nbPointsNeg;
    public int total;
}
