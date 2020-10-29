using UnityEngine;

public class PracticaGitBehaviour : MonoBehaviour {
    [SerializeField]
    [Tooltip("Introducir nombre del autor")]
    private string nombreAutor;

    
    private void Start() {

        Debug.Log("Practica realizada por: ");
        Debug.Log("Autor de la practica/Practica realizada por: ");
        Debug.Log(nombreAutor);
       
    }
}