using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PBala : MonoBehaviour
{

    void OnEnable(){
        StartCoroutine(DesactivarPorTiempo());
    }

    void OnDisable() {
        StopAllCoroutines();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 10 * Time.deltaTime, 0);
    }

    IEnumerator DesactivarPorTiempo(){

        yield return new WaitForSeconds(3);
        PBalitaManager.Instance.DesactivarBala(gameObject);
    }

    void OnCollisionEnter(Collision c){
        PBalitaManager.Instance.DesactivarBala(gameObject);
    }
}
