using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PBala : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 10 * Time.deltaTime, 0);
    }
}
