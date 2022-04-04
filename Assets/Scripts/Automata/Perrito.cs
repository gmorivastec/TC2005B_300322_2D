using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perrito : MonoBehaviour
{

    [SerializeField]
    private Transform desconocido;

    [SerializeField]
    private float frecuenciaDeRevision;

    [SerializeField]
    private float distanciaValida;

    // Estados del perrito
    private ANode actual;
    private MonoBehaviour comportamientoActual;

    // Start is called before the first frame update
    void Start()
    {
        if(desconocido == null)
            throw new System.Exception("DESCONOCIDO NO ASIGNADO EN PERRITO");

        // estados
        ANode contento = new ANode("CONTENTO", typeof(ContentoBehaviour));
        ANode dormido = new ANode("DORMIDO", typeof(DormidoBehaviour));
        ANode alterado = new ANode("ALTERADO", typeof(AlteradoBehaviour));

        // función de transferencia
        contento.AgregarArco(ANode.Lenguaje.PASA_DESCONOCIDO, alterado);
        contento.AgregarArco(ANode.Lenguaje.JUGAR, dormido);

        dormido.AgregarArco(ANode.Lenguaje.ACARICIAR, contento);
        dormido.AgregarArco(ANode.Lenguaje.PASA_DESCONOCIDO, alterado);

        alterado.AgregarArco(ANode.Lenguaje.ACARICIAR, contento);
        alterado.AgregarArco(ANode.Lenguaje.JUGAR, dormido);

        actual = contento;
        comportamientoActual = gameObject.AddComponent(actual.Comportamiento) as MonoBehaviour;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.A)){
            CambiarEstado(ANode.Lenguaje.ACARICIAR);
        }

        if(Input.GetKeyUp(KeyCode.J)){
            CambiarEstado(ANode.Lenguaje.JUGAR);
        }

        /*
        if(Input.GetKeyUp(KeyCode.D)){
            CambiarEstado(ANode.Lenguaje.PASA_DESCONOCIDO);
        }
        */
    }

    private void CambiarEstado(ANode.Lenguaje simbolo){

        // verificar nuevo simbolo vs anterior
        ANode nuevoEstado = actual.AplicarSimbolo(simbolo);

        if(nuevoEstado == actual) 
            return;
            
        // actualizar actual
        actual = nuevoEstado; 

        // destruir componente anterior
        Destroy(comportamientoActual);

        // agregar componente nuevo
        comportamientoActual = gameObject.AddComponent(actual.Comportamiento) as MonoBehaviour;
    }

    private IEnumerator ChecarDesconocido(){

        while(true){


            // revisar distancia
            float d = Vector3.Distance(transform.position, desconocido.position);

            if(d < distanciaValida)
                CambiarEstado(ANode.Lenguaje.PASA_DESCONOCIDO);
                
            // esperar
            yield return new WaitForSeconds(frecuenciaDeRevision);
        }
    }
}
