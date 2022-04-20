using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PBalitaManager : MonoBehaviour
{

    // contenedor de objetos
    // Array List  
    private Dictionary<GameObject, int> pool;
    private Queue<GameObject> objetosDisponibles;

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

        pool = new Dictionary<GameObject, int>();
        objetosDisponibles = new Queue<GameObject>();

        // creación de objetos de pool
        for(int i = 0; i < maxPool; i++){
            
            // instanciar
            GameObject nuevo = Instantiate<GameObject>(balita);
            
            // agregar a pool
            pool.Add(nuevo, i);
            objetosDisponibles.Enqueue(nuevo);

            // deshabilitar
            nuevo.SetActive(false);
        }
    }

    public void ActivarBala(Vector3 pos){

        if(objetosDisponibles.Count == 0)
            return;

        GameObject actual = objetosDisponibles.Dequeue();

        actual.transform.position = pos;
        actual.SetActive(true);
        
    }

    public void DesactivarBala(GameObject bala){

        // 1ero - checa que sea parte del pool
        if(!pool.ContainsKey(bala))
            return;

        objetosDisponibles.Enqueue(bala);
        bala.SetActive(false);
    }

}
