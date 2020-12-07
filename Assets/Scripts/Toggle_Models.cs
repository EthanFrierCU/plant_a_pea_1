﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toggle_Models : MonoBehaviour
{

    public float storyTime = 0f;
    public bool naturalTimeMode;
    public bool controlTimeMode;
    public Forcefield_Attract seedInPlace;
    public GameObject Seed;
    public GameObject Model0;
    public GameObject Model1;
    public GameObject Model2;
    public GameObject Model3;
    public GameObject Model4;
    public GameObject Model5;

    // Start is called before the first frame update
    void Start()
    {
        naturalTimeMode = true;
    }

    // Update is called once per frame
    void Update()
    {

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
        if (storyTime > 0 & storyTime < 1)
        {
            if (!Model0.activeInHierarchy)
            {
                Model0.SetActive(true);
            }
        }

        if (storyTime >= 1 & storyTime < 2)
        {
            if (!Model1.activeInHierarchy)
            {
                Model0.SetActive(false);
                Model1.SetActive(true);
            }
        }

        if (storyTime >= 2 & storyTime < 3)
        {
            if (!Model2.activeInHierarchy)
            {
                Model1.SetActive(false);
                Model2.SetActive(true);
            }
        }

        if (storyTime >= 3 & storyTime < 4)
        {
            if (!Model3.activeInHierarchy)
            {
                Model2.SetActive(false);
                Model3.SetActive(true);
            }
        }

        if (storyTime >= 4 & storyTime < 5)
        {
            if (!Model4.activeInHierarchy)
            {
                Model3.SetActive(false);
                Model4.SetActive(true);
            }
        }

        if (storyTime >= 5 & storyTime < 6)
        {
            if (!Model5.activeInHierarchy)
            {
                Model4.SetActive(false);
                Model5.SetActive(true);
            }
        }

    }
}
