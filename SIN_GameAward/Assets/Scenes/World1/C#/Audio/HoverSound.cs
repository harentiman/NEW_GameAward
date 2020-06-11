using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverSound : MonoBehaviour
{
    public AudioSource myFX;
    public AudioClip hoverFx;


    public void HoverSE()
    {
        myFX.PlayOneShot(hoverFx);
    }

}