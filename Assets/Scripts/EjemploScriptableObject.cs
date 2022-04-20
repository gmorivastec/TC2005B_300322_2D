using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Definición de un contenedor de datos 
// diferencia vs una clase regular:
// - podemos crear predefiniciones de scriptable objects como assets

[CreateAssetMenu(menuName = "ScriptableObjects/Ejemplo")]
public class EjemploScriptableObject : ScriptableObject
{
    // lo que tiene aquí es puro valor
    public int defensa;
    public int ataque;
    public string nombre;
    public GameObject proyectil;

}
