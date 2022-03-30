using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{

    [SerializeField]
    private float speed = 5;
    
    [SerializeField]
    private GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        // SUPER IMPORTANTE
        // ESTRATEGIA DE DESTRUCCIÓN DE OBJETOS
        Destroy(gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, speed * Time.deltaTime, 0);
    }

    void OnCollisionEnter2D(Collision2D c){
        ContactPoint2D contacto = c.GetContact(0);

        Instantiate(
            explosion, 
            new Vector3(contacto.point.x, contacto.point.y, 0), 
            explosion.transform.rotation);
        Destroy(c.gameObject);
        Destroy(gameObject);
    }
    void OnCollisionStay2D(Collision2D c){}
    void OnCollisionExit2D(Collision2D c){}

    void OnTriggerEnter2D(Collider2D c){}
    void OnTriggerStay2D(Collider2D c){}
    void OnTriggerExit2D(Collider2D c){}
}
