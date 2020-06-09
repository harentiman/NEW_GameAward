﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gole : MonoBehaviour
{
    public static bool Gole=false;
    public static int stagenumber;
    // Start is called before the first frame update
    public static string a;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //stage01

            Gole = true;
            stagenumber = SceneManager.GetActiveScene().buildIndex;
            int i = SceneManager.GetActiveScene().buildIndex;   //ステージビルド番号
            string s = i.ToString();                            //ビルド番号をstring型にする

            // 最終ステージクリア後、タイトルに戻る
            if (SceneManager.GetActiveScene().buildIndex == 16)
            {
                FadeManager.Instance.LoadScene("StageSelect", 2);
            }

            // 次のステージ
            Gole = false;
            FadeManager.Instance.LoadScene("stage" + s, 2);
        }
    }  

}
