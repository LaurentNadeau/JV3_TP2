using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class JoueurController : MonoBehaviour
{
    [Tooltip("Vitesse de mouvement du personnage en m/s")]
    [SerializeField] private float _vitesseMouvement = 5f;
    [SerializeField] private float _forceSaut = 5f;
    [SerializeField] private float _multiplicateurCourse = 2f;

    //Sons à utiliser pour le déplacement du personnage
    [SerializeField] private AudioClip[] _listeBruitsPas;
    [SerializeField] private AudioClip _sonSaut;
    [SerializeField] private AudioClip _sonTombeAuSol;

    // Variables pour les délais pour faire jouer les bruits de pas
    [Tooltip("Le délai en secondes entre les bruits de pas si on marche")]
    [SerializeField] private float _delaiBruitPasMarche = 2.0f;
    [Tooltip("Le délai en secondes entre les bruits de pas si on court")]
    [SerializeField] private float _delaiBruitPasCourse = 1.0f;
    private float _compteurDeTempsBruitsPas = 0.0f;

    private Rigidbody _rb;
    private AudioSource _audioSource;
    private bool _isGrounded = true; 
    private bool _courir = false; //Si on est en train de courir
    private Vector2 _movementInput;
    private Vector2 _mouseDelta;
    private float _deltaRotationX;
    private float _deltaRotationY;



    [Range(-45, -15)]
    public int minAngle = -30;
    [Range(30, 80)]
    public int maxAngle = 45;
    [Range(10, 100)]
    [SerializeField] private float _sensibiliteSouris = 200;


    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _audioSource = GetComponent<AudioSource>();

        Cursor.lockState = CursorLockMode.Locked;

    }

    void LateUpdate()
    {

        //La vitesse Final est la vitesse qui sera utilisé pour déplacer le personnage
        float _vitesseFinal = _vitesseMouvement;

        //Si le personnage est en train de courir
        if (_courir)
        {   
            //On multiplie sa vitesse de mouvement
            _vitesseFinal = _vitesseMouvement * _multiplicateurCourse;
        }

        //Détermine la direction de mouvement selon les touches du clavier reçus
        float mouvementGaucheDroite = _movementInput.x * _vitesseFinal;
        float mouvementAvantArriere = _movementInput.y * _vitesseFinal;

        //Si il y a du mouvement
        if (mouvementGaucheDroite != 0 || mouvementAvantArriere != 0)
        {
            //Si le personnage est au sol
            if (_isGrounded)
            {
                JouerBruitsDePas();
            }
        }

        // Convertir la vélocité locale en vélocité globale
        Vector3 globalVelocity = transform.TransformDirection(mouvementGaucheDroite,0,mouvementAvantArriere);

        // Définir la vélocité de l'objet
        _rb.velocity = new Vector3(globalVelocity.x, _rb.velocity.y, globalVelocity.z);
         
    }


    void JouerBruitsDePas()
    {
        // Incrémenter le compteur de temps
        _compteurDeTempsBruitsPas += Time.deltaTime;
        
        //Initialise une variable qui va contenir le délai avant de jouer le son à nouveau
        float delai = 0;

        //Affecte le bon délai selon si le personne court ou pas
        if (_courir)
        {
            delai = _delaiBruitPasCourse;
        }
        else
        {
            delai = _delaiBruitPasMarche;
        }

        // Vérifier si le délai est écoulé
        if (_compteurDeTempsBruitsPas > delai)
        {   
            //Fait jouer un son aléatoire dans la liste de son de bruits de pas
            int randomIndex = Random.Range(0, _listeBruitsPas.Length);
            _audioSource.clip = _listeBruitsPas[randomIndex];
            _audioSource.Play();

            // Réinitialiser le compteur de temps
            _compteurDeTempsBruitsPas = 0.0f;
        }

        
    }

    //Lorsqu'on appuie sur la touche "Shift"
    void OnRun(InputValue value)
    {
        if(value.isPressed)
        {
            _courir = true;
        }
        else
        {
            _courir = false;
        }
    }

    //Lorsqu'on déplace la souris
    void OnLook(InputValue value)
    {
        //Delta représente la quantité de mouvement de la souris dans les deux axe (X et Y) depuis la dernière lecture
        Vector2 delta = value.Get<Vector2>();

        //Calcul la quantité de rotation à effectuer dans l'axe X et Y selon la sensibilité de la souris
        _deltaRotationY = delta.x * _sensibiliteSouris * Time.fixedDeltaTime;
        _deltaRotationX = delta.y * _sensibiliteSouris * Time.fixedDeltaTime;

        //Récupère l'orientation local du joueur
        Vector3 currentRotation = transform.localRotation.eulerAngles;
        
        //Convertir une rotation de 0 à 360 degrés vers -180 à 180 degrés
        float rotationX = convertirRotationEn180Degres(currentRotation.x - _deltaRotationX);

        //On limite la rotation entre degr.s afin d'.viter de faire un tour complet haut/bas
        rotationX = Mathf.Clamp(rotationX, minAngle, maxAngle);
        
        //Calcul la nouvelle rotation dans l'axe Y
        float rotationY = currentRotation.y + _deltaRotationY;

        //On applique la rotation X et Y au composent transform de l'objet où se trouve ce script
        transform.localRotation = Quaternion.Euler(rotationX, rotationY, 0f);
    }

    void OnJump()
    {
        if (_isGrounded)
        {
            _rb.AddForce(Vector3.up * _forceSaut, ForceMode.Impulse);
            _isGrounded = false;

            //Fait jouer le son du saut
            _audioSource.clip = _sonSaut;
            _audioSource.Play();
        }
    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Sol"))
        {
            _isGrounded = true;

            //Fait jouer le son lorsqu'on tombe au sol
            _audioSource.clip = _sonTombeAuSol;
            _audioSource.Play();
        }
    }

  

    public void OnMove(InputValue value)
    {
        _movementInput = value.Get<Vector2>();
    }

    //Pour convertir une rotation de 0 à 360 degrés vers -180 à 180 degrés
    private float convertirRotationEn180Degres(float valeurRotation)
    {
        float rotationFinale;

        if(valeurRotation > 180f) {
            rotationFinale = valeurRotation - 360f;
        }
        else {
            rotationFinale = valeurRotation;
        }

        return rotationFinale;
    }
}
