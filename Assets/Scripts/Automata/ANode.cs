using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ANode
{
    // enumeración
    // tipo de dato con espacio de posibles valores limitado
    public enum Lenguaje{
        PASA_DESCONOCIDO,
        ACARICIAR,
        JUGAR
    };

    // propiedad - property
    public string Nombre {
        get;
        private set;
    }

    public Type Comportamiento {
        get;
        private set;
    }

    // Diccionario - estructura de datos que contiene información
    // guardada en tuplas llave - valor 

    // acceso tiene complejidad O(1)
    // similar a un arreglo 
    private Dictionary<Lenguaje, ANode> transferencia;


    public ANode(string nombre, Type comportamiento){
        
        this.Nombre = nombre;
        this.Comportamiento = comportamiento;
        transferencia = new Dictionary<Lenguaje, ANode>();
    }

    public void AgregarArco(Lenguaje simbolo, ANode objetivo){
        transferencia.Add(simbolo, objetivo);
    }

    public ANode AplicarSimbolo(Lenguaje simbolo){

        if(!transferencia.ContainsKey(simbolo))
            return this;

        return transferencia[simbolo];
    }

    public int Sumar(int n1, int n2){

        return n1 + n2;
    }
}
