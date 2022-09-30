using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Josefina Elisa Figueroa Ubilla
// Prueba 1
public class Player : MonoBehaviour
{   
    // Región con el nombre CLASS_VARIABLES 
    #region CLASS_VARIABLES
    // Variable de velocidad
    [SerializeField] private float velocidad = 0.01f;

    // Variable que almacena monedas obtenidas
    public int monedas = 0;

    // Variable que almacena el nombre del jugador
    [SerializeField] private string nombreJugador = "Jugador";

    #endregion  

    // Start is called before the first frame update
    void Start()
    {   // Al iniciar el juego muestre un mensaje en consola 
        Debug.Log("Juego Iniciado, el protagonista está listo para sacarse un 70 en esta prueba");

    }

    // Update is called once per frame
    void Update()
    {
        menosMonedasOnClick();
        Movement();
        
    }

    // Metodo que resta monedas al jugador
    public void menosMonedasOnClick()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            monedas--;
        }
    }

    // Metodo que mueve al jugador
    public void Movement()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-velocidad, 0, 0);
        }

    }

    // Metodo de la clase Player que detecta colisiones
    public void OnCollisionEnter(Collision collision)

    {
        if (collision.gameObject.tag == "Moneda")
        {
            monedas++;
            Debug.Log("Usted intercepto con una moneda, así que le daré una moneda");
        }
        Debug.Log("Intersección con: " + collision.gameObject.name);
    }
    
}
