using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Toggle_Models_cactus : MonoBehaviour
{
    public bool debug;
    public float storyTime = 0f;
    public string activeModel;
    public bool naturalTimeMode;
    public bool controlTimeMode;
    public Forcefield_Attract seedInPlace;
    public GameObject Seed;
    public GameObject CactusPrefab;
    public TextMesh debugModels;


    // Start is called before the first frame update
    void Start()
    {
        naturalTimeMode = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(debug)
        {
            Debug.Log(activeModel);
            debugModels.text = activeModel;
        }

        if(seedInPlace.storyStart)
        {
            if(Seed.activeInHierarchy)
            {
                Seed.SetActive(false);
            }

            if(naturalTimeMode)
            {
                storyTime += Time.deltaTime;
            }

            StoryBoard();
        }

    }

    void StoryBoard()
    {
        if (storyTime > 0)
        {
            if (!CactusPrefab.activeInHierarchy)
            {
                CactusPrefab.SetActive(true);
                activeModel = "seed planted";
            }
        }

    }
}
