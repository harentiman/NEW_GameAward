using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeSE : MonoBehaviour
{
    public AudioClip sound4;
    AudioSource AudioSource;
    // Start is called before the first frame update
    void Start()
    {
        AudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            {
                AudioSource.PlayOneShot(sound4);
            }
        }
    }
}
