using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;


public class Audio : MonoBehaviour
{


    public AudioMixer mixer;
    public Slider BGM;
    public Slider SE;

    // Start is called before the first frame update
    void Start()
    {
     

    }

    // Update is called once per frame
    void Update()
    {
        
        mixer.SetFloat("BGM", BGM.value);
        mixer.SetFloat("SE", SE.value);

    }
}
