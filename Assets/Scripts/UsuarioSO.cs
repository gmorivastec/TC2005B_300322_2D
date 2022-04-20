using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsuarioSO : MonoBehaviour
{

    [SerializeField]
    private EjemploScriptableObject datos;

    private int ataque, defensa;

    // Start is called before the first frame update
    void Start()
    {
        print(datos.ataque);
        print(datos.defensa);
        print(datos.nombre);

        ataque = datos.ataque;
        defensa = datos.defensa;
    }
}
