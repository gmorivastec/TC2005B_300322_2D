using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Ken : MonoBehaviour
{

    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");

        float velocidad = h * 5 * Time.deltaTime;
        
        transform.Translate(velocidad, 0, 0);
        anim.SetFloat("velocidad", velocidad);


        if(Input.GetKeyDown(KeyCode.Space)){
            anim.SetTrigger("hadouken");
        }
    }

    public void Hadouken(){

        print("HADOUKEN!");
    }
}
