using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textfade : MonoBehaviour
{
    float fadeSpeed = 0.0075f;              //透明度が変わるスピードを管理
    float red, green, blue, alfa;           //パネルの色、不透明度を管理
    bool isFadeOut = false;                 //フェードアウト処理の開始、完了を管理するフラグ
    private Image fadetext;                  //透明度を変更するパネルのイメージ

    // Start is called before the first frame update
    void Start()
    {
        fadetext = GetComponent<Image>();
        red = fadetext.color.r;
        green = fadetext.color.g;
        blue = fadetext.color.b;
        alfa = fadetext.color.a;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(isFadeOut);
     
        StartFadeOut();
        
    }

    void StartFadeOut()
    {
        fadetext.enabled = true;  // a)パネルの表示をオンにする
        alfa += fadeSpeed;         // b)不透明度を徐々にあげる
        SetAlpha();               // c)変更した透明度をパネルに反映する
        if (alfa >= 1)
        {             // d)完全に不透明になったら処理を抜ける
            //isFadeOut = false;
            //isFadeIn = true;
        }
    }

     void SetAlpha()
    {
        fadetext.color = new Color(red, green, blue, alfa);
    }
}
