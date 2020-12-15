using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playSound : MonoBehaviour
{

    public AudioSource Bell;

    public void PlayBell()
    {

        Bell.Play();
    }
}
