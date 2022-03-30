using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    [SerializeField]
    private float speed = 5;

    [SerializeField]
    private float shotTime = 1;

    [SerializeField]
    private GameObject proyectil;

    private IEnumerator shotCoroutine;

    // Start is called before the first frame update
    void Start()
    {
        if(proyectil == null){

            Debug.LogError("PROYECTIL NO ASIGNADO");
            throw new System.Exception("PROYECTIL NO ASIGNADO");
        }

        shotCoroutine = Disparo();
    }

    // Update is called once per frame
    void Update()
    {

        // [-1, 1]
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.Translate(
            h * speed * Time.deltaTime, 
            v * speed * Time.deltaTime, 
            0);

        if(Input.GetKeyDown(KeyCode.Space)){
            StartCoroutine(shotCoroutine);
        }

        if(Input.GetKeyUp(KeyCode.Space)){
            StopCoroutine(shotCoroutine);
        }
    }

    // pseudo concurrencia
    // las corrutinas dependen del componente
    private IEnumerator Disparo(){
        
        while(true){

            Instantiate(proyectil, transform.position, transform.rotation);
            yield return new WaitForSeconds(shotTime);
        }
    }
}
