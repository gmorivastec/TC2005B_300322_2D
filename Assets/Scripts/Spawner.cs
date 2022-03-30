using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    [SerializeField]
    private GameObject enemigo;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GenerarEnemigo());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator GenerarEnemigo(){

        while(true){

            // generar enemigo con x random
            Instantiate(
                enemigo, 
                new Vector3(Random.Range(-7, 7), 3.5f, 0), // [-7, 7]
                enemigo.transform.rotation
                );

            // esperar con tiempo random
            yield return new WaitForSeconds(Random.Range(0.25f, 2));
        }
    }

}
