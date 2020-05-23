using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gole : MonoBehaviour
{
    public static bool Gole;
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
            string st = SceneManager.GetActiveScene().name;     //ステージ名
            int i = SceneManager.GetActiveScene().buildIndex;   //ステージビルド番号
            string s = i.ToString();                            //ビルド番号をstring型にする
            st=st.Substring(0, st.Length - s.Length);           //ステージ名からビルド番号以外取る
            string str = st + s;                                //組み合わせる

            // 最終ステージクリア後、タイトルに戻る
            if (SceneManager.GetActiveScene().buildIndex == 17)
            {
                FadeManager.Instance.LoadScene("title", 2);
            }


            stagenumber = SceneManager.GetActiveScene().buildIndex;
            int syou = (SceneManager.GetActiveScene().buildIndex) - 5; //stage-4-1の4の部分計算
            int mod = (SceneManager.GetActiveScene().buildIndex) % 5;  //stage-4-1の1の部分計算
            string b = st.Substring(0, st.Length - 3);
            syou += 1;
            a = b + syou + ("-") + mod;


            // 次のステージ
            FadeManager.Instance.LoadScene(str, 2);
        }
    }  

}
