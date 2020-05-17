using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Audio : MonoBehaviour
{
    public AudioMixer audioMixer;

    public Slider BGMSlider;
    public Slider SESlider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        audioMixer.SetFloat("BGM", BGMSlider.value);
        audioMixer.SetFloat("SE", SESlider.value);
    }
}
