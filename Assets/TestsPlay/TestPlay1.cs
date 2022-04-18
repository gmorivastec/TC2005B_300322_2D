using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestPlay1
{

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.

    // los UnityTest requieren que se ejecute el juego para correr la prueba
    [UnityTest]
    public IEnumerator Test1()
    {

        yield return new WaitForSeconds(2);
        

        string texto = "hola";
        Assert.That(texto, Is.EqualTo("hola"));

        Assert.That("adios", Is.EqualTo("adios"));

        Assert.That(":)", Is.EqualTo(":)"));

        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }

    [UnityTest]
    public IEnumerator Test2()
    {

        yield return new WaitForSeconds(5);

        string texto = "hola";
        Assert.That(texto, Is.EqualTo("hola"));

        Assert.That("adios", Is.EqualTo("adios"));

        Assert.That(":)", Is.EqualTo(":)"));

        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
