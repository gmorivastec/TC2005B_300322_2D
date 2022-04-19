using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PPersonaje : MonoBehaviour
{
    [SerializeField]
    private GameObject balaOriginal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.Translate(h * 10 * Time.deltaTime, v * 10 * Time.deltaTime, 0);


        if(Input.GetKeyDown(KeyCode.Space)){

            //Instantiate(balaOriginal, transform.position, transform.rotation);

            // "crear" utilizando el pool
            PBalitaManager.Instance.ActivarBala(transform.position);
        }
    }
}
