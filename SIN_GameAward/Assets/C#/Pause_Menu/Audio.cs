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
    private float BGMvolume;
    private float SEvolume;

    // Start is called before the first frame update
    void Start()
    {

        BGMSlider.value = PlayerPrefs.GetFloat("BGM", 0);
        SESlider.value = PlayerPrefs.GetFloat("SE", 0);
        if (audioMixer.GetFloat("BGM", out BGMvolume))
        {
            BGMSlider.value = BGMvolume;
        }
        if (audioMixer.GetFloat("BGM", out SEvolume))
        {
            SESlider.value = SEvolume;
        }
    }

    void Update()
    {
        BGM(BGMSlider);
        SE(SESlider);
    }

    // Update is called once per frame
    public void BGM(Slider slider)
    {
        audioMixer.SetFloat("BGM", slider.value);
    }

    public void SE(Slider slider)
    {
        audioMixer.SetFloat("SE", slider.value);
    }
}
