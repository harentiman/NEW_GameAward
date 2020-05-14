using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gole : MonoBehaviour
{
    // Start is called before the first frame update
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
        {//stage01


            //string s = i.ToString();                            //ビルド番号をstring型にする
            //st=st.Substring(0, st.Length - s.Length);           //ステージ名からビルド番号以外取る
            //string str = st + s;                                //組み合わせる

            string st = SceneManager.GetActiveScene().name;     //ステージ名
            int i = SceneManager.GetActiveScene().buildIndex;   //ステージビルド番号
            int syou = (SceneManager.GetActiveScene().buildIndex - 2) / 4; //stage-4-1の4の部分計算
            int mod = (SceneManager.GetActiveScene().buildIndex - 2) % 4;  //stage-4-1の1の部分計算
            mod += 2;
            syou += 1;
            string b = st.Substring(0, st.Length - 3);
            string a = b + syou + ("-")+mod;


            //Debug.Log(str);
            Debug.Log(syou);
            Debug.Log(mod);
            Debug.Log(b);
            Debug.Log(a);
            FadeManager.Instance.LoadScene(a, 2f);

          
        }
    }  
}
