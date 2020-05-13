﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BGM : MonoBehaviour
{
    AudioSource m_AudioSource;
    public Slider m_Slider;

    private bool m_Play;
    public bool m_ToggleChange;
    void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();
        m_Slider=GetComponent<Slider>();
        m_Play = true;
    }

    void Update()
    {
        m_AudioSource.volume = m_Slider.normalizedValue;
    }
}