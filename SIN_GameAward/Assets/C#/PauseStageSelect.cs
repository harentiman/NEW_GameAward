﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseStageSelect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OnClick()
    {
        FadeManager.Instance.LoadScene("StageSelect", 2f);
    }
}
