using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class Pruebas1
{
    // A Test behaves as an ordinary method
    [Test]
    public void Pruebita1()
    {
        // Modelo clásico
        // - los constraints (restricciones) están definidos por medio de métodos
        // - existe 1 método por tipo de constraint
        ANode nodo = new ANode("prueba", typeof(DormidoBehaviour));
        Assert.AreEqual(15, nodo.Sumar(12, 3));
        Assert.AreEqual(-2, nodo.Sumar(1, -3));
    }

    [Test]
    public void Pruebita2()
    {
        // nuevo modelo - 
        // - las constraints pasan como objeto, ya hay unas definidas y nosotros 
        // podemos definir nuevas

        string texto = "hola";
        Assert.That(texto, Is.EqualTo("hola"));

        Assert.That("adios", Is.EqualTo("adios"));

        Assert.That(":)", Is.EqualTo(":)"));

         
        
        // pon en un métodos todos los asserts que corresponden 
        // a las pruebs que harías en un método  de tu código
    }

    [Test]
    public void Pruebita3()
    {
        
    }
}
