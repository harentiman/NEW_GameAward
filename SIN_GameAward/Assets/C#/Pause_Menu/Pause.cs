using System.Collections;
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


    void Start()
    {
        CopyPauseUI = pauseUI;
        CopyOptionUI = optionUI;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //　ポーズUIのアクティブ、非アクティブを切り替え
            pauseUI.SetActive(!pauseUI.activeSelf);
            optionUI.SetActive(false);

            //　ポーズUIが表示されてる時は停止
            if (pauseUI.activeSelf)
            {
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
