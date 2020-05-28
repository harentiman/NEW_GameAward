using UnityEngine;
using System.Collections;
using UnityEngine.UI;

// 自動で消える
public class Stage_UI : MonoBehaviour
{

    float fadeSpeed = 0.0075f;              //透明度が変わるスピードを管理
    float red, green, blue, alfa;           //パネルの色、不透明度を管理
    bool isFadeOut = false;                 //フェードアウト処理の開始、完了を管理するフラグ
    bool isFadeIn = false;                  //フェードイン処理の開始、完了を管理するフラグ

    private Text fadetext;                  //透明度を変更するパネルのイメージ

    void Start()
    {
        fadetext = GetComponent<Text>();
        red = fadetext.color.r;
        green = fadetext.color.g;
        blue = fadetext.color.b;
        alfa = fadetext.color.a;
        StartCoroutine("Fade");
    }

    void Update()
    {

        if (isFadeOut == true)
        {
            StartFadeOut();
        }
        if (isFadeIn == true)
        {
            StartFadeIn();
        }
    }

    void StartFadeIn()
    {
        alfa -= fadeSpeed;                //a)不透明度を徐々に下げる
        SetAlpha();                      //b)変更した不透明度パネルに反映する
        if (alfa <= 0)
        {                    //c)完全に透明になったら処理を抜ける
            isFadeIn = false;
            fadetext.enabled = false;    //d)パネルの表示をオフにする
        }
    }

    void StartFadeOut()
    {
        fadetext.enabled = true;  // a)パネルの表示をオンにする
        alfa += fadeSpeed;         // b)不透明度を徐々にあげる
        SetAlpha();               // c)変更した透明度をパネルに反映する
        if (alfa >= 1)
        {             // d)完全に不透明になったら処理を抜ける
            isFadeOut = false;
            StartCoroutine("Text");
            //isFadeIn = true;
        }
    }

    void SetAlpha()
    {
        fadetext.color = new Color(red, green, blue, alfa);
    }

    IEnumerator Text()
    {
        yield return new WaitForSeconds(1);
        isFadeIn = true;
    }
    IEnumerator Fade()
    {
        yield return new WaitForSeconds(2.5f);
        isFadeOut = true;
    }

}
