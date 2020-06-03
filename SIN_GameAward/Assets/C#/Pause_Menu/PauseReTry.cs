﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseReTry: MonoBehaviour
{
    public Button ReTryButton;

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
        ReTryButton.interactable = false;
        Time.timeScale = 1;

        // Player削除
        GameObject obj = GameObject.FindGameObjectWithTag("Player");
        Destroy(obj);

        // Enemy削除（位置リセット）
        GameObject ene = GameObject.FindGameObjectWithTag("Enemys");
        Destroy(ene);


        FadeManager.Instance.LoadScene(SceneManager.GetActiveScene().name, 2f);
    }
}
