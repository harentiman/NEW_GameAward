using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMoving : MonoBehaviour
{
    //volume: 0..1
    public AudioClip MovingCube;
    AudioSource AudioSource;

    private void Start()
    {
        AudioSource = GetComponent<AudioSource>();
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = MovingCube;
    }
 

    void OnCollisionEnter(Collision col)
    {
        // GetComponent<AudioSource>().Play();

        if (col.gameObject.CompareTag("Player"))
        {
            Debug.Log("hit");

            GetComponent<AudioSource>().Play();
            
        }
            


        /*if (!AudioSource.isPlaying && col.relativeVelocity.magnitude >= 2)
        {
            AudioSource.volume = col.relativeVelocity.magnitude / 20;
            AudioSource.PlayOneShot(MovingCube);
            Debug.Log(col.relativeVelocity.magnitude);
        } */

        //if (col.gameObject.tag == "Ground")
        //{
        //    AudioSource.PlayOneShot(MovingCube);

        //}
    }
}


