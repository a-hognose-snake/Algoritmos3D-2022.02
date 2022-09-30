using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace APICLASS
{
    // Mi clase hereda MonoBehaviour (clase padre)
    public class HelloWorld : MonoBehaviour
    {
        #region CLASS_VARIABLES
        [Header("Variables")]
        // Visibilidad, tipo de dato, nombre de la variable
        // [SerializeField] es para que Unity pueda ver la variable
        [SerializeField]private int privateNumber = 4;
        // Se ve en el inspector y se puede cambiar directamente
        public int publicNumber = 5;
        public string publicString = "Hello World";
        public float publicFloat = 3.14f;
        public string[] publicStringArray = new string[3];
        public string[] publicStringArray2;

        [Header("References")]
        [SerializeField] private GameObject privateGameObject;
        #endregion

        #region UNITY_METHODS
        // Awake is called before Start
        void Awake()
        {
            Debug.Log("Hello World before start");
        }

        // Start is called before the first frame update
        void Start()
        {
            // Esto se va a ejecutar solamente al inicio del juego
            Debug.Log("Hello World one time");
            
        }

        // Update is called once per frame
        void Update()
        {
            // Esto se va a ejecutar cada frame
            Debug.Log("Hello World every frame");
            
        }

        // OnEnable is called when the script instance is being loaded
        void OnEnable()
        {
            // Esto se va a ejecutar cuando el objeto se active
            Debug.Log("Hello World when enabled");
        }

        // OnDisable is called when the script instance is being disabled
        void OnDisable()
        {
            // Esto se va a ejecutar cuando el objeto se desactive
            Debug.Log("Hello World when disabled");
        }
        #endregion
    }  
}

