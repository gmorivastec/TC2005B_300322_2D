using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PBalitaManager : MonoBehaviour
{

    // contenedor de objetos
    // Array List  
    private List<GameObject> pool;
    private int ultimoDisponible;

    [SerializeField]
    private int maxPool;

    [SerializeField]
    private GameObject balita;


    // como todo manager hay que hacerlo un singleton
    public static PBalitaManager Instance {
        get;
        private set;
    }

    // Start is called before the first frame update
    void Start()
    {

        // mecanismo de singleton 
        if(Instance != null){
            Destroy(gameObject);
        }

        Instance = this;

        pool = new List<GameObject>();

        // creación de objetos de pool
        for(int i = 0; i < maxPool; i++){
            
            // instanciar
            GameObject nuevo = Instantiate(balita) as GameObject;
            
            // agregar a pool
            pool.Add(nuevo);

            // deshabilitar
            nuevo.SetActive(false);
        }

        ultimoDisponible = 0;
    }

    public void ActivarBala(Vector3 pos){

        pool[ultimoDisponible].transform.position = pos;
        pool[ultimoDisponible].SetActive(true);
        ultimoDisponible++;
    }

}
