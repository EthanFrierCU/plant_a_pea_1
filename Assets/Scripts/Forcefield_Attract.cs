using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CUVR;

public class Forcefield_Attract : MonoBehaviour
{
    public bool debug;
    public Transform pea;
    public float speed = 1;
    Vector3 targetPosition;
    bool inForcefield;
    public bool storyStart;
    public TextMesh debugModels;

    // Start is called before the first frame update
    void Start()
    {
        targetPosition = new Vector3(0f, -0.5f, 1f);
        inForcefield = false;
        storyStart = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PeaSeed"))
        {
            other.transform.gameObject.GetComponent<Interactable>().enabled = false;
            other.transform.parent = null;
            other.transform.parent = this.transform;
            pea = other.transform;
            inForcefield = true;
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
                storyStart = true;
            }

            if(debug)
            {
                Debug.Log("planting");
                debugModels.text = "planting";
            }
        }

    }

}