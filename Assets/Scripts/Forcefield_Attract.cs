using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CUVR;

public class Forcefield_Attract : MonoBehaviour
{
    public Transform pea;
    public float speed = 1;
    Vector3 targetPosition;
    bool inForcefield;

    // Start is called before the first frame update
    void Start()
    {
        targetPosition = new Vector3(0f, -0.5f, 1f);
        inForcefield = false;
    }

    void OnTriggerEnter(Collider other)
    {
        other.transform.gameObject.GetComponent<Interactable>().enabled = false;
        if (other.CompareTag("PeaSeed"))
        {
            other.transform.parent = null;
            other.transform.parent = this.transform;
            inForcefield = true;
            pea = other.transform;
        }
    }

    void Update()
    {
        if (inForcefield)
        {
            float step = speed * Time.deltaTime;
            pea.transform.position = Vector3.MoveTowards(pea.transform.position, targetPosition, step);

            if (Vector3.Distance(pea.transform.position, targetPosition) < 0.001f)
            {
                inForcefield = false;
            }
        }

    }

}