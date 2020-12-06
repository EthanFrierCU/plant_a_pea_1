using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forcefield_Attract : MonoBehaviour
{
    public Rigidbody pea; 

    // Start is called before the first frame update
    void Start()
    {
        pea = GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(Collider other)
    {
       if(other.CompareTag("PeaSeed"))
        {
            other.transform.parent = null;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("PeaSeed"))
        {
            other.transform.parent = this.transform;
        }
    }
    
}
