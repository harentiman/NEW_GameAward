﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    //　ポーズした時に表示するUI
    public GameObject pauseUI;
    public GameObject optionUI;
    public static GameObject CopyPauseUI;
    public static GameObject CopyOptionUI;
    public Selectable mySelectable;


    void Start()
    {
        CopyPauseUI = pauseUI;
        CopyOptionUI = optionUI;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)||Input.GetKeyDown("joystick button 7"))
        {
            //　ポーズUIのアクティブ、非アクティブを切り替え
            pauseUI.SetActive(!pauseUI.activeSelf);
            mySelectable.Select();
            optionUI.SetActive(false);

            //　ポーズUIが表示されてる時は停止
            if (pauseUI.activeSelf)
            {
                mySelectable.Select();
                Time.timeScale = 0f;
                //　ポーズUIが表示されてなければ通常通り進行
            }
            else
            {
                Time.timeScale = 1f;
            }
        }
    }
    
}
