using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class DetectCollsions : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    void OnTriggerEnter(Collider other)

    {
      //  transform.localScale *= 2;

     
     Destroy(gameObject);
       Destroy(other.gameObject);
    }
}
