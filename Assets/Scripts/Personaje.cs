using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Personaje : MonoBehaviour
{

    private CharacterController controller;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();    
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        //controller.SimpleMove(new Vector3(h * 10, 0, v * 10));
        controller.Move(new Vector3(h * 10 * Time.deltaTime, 0, v * 10 * Time.deltaTime));
    }

    void OnControllerColliderHit(ControllerColliderHit c){
        print("COLISIONANDO CON: " + c.transform.name);
    }
}
