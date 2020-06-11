using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageSelect : MonoBehaviour
{
   
    public Button button;
    public int stagenumber;
    public static string s;

    bool OnlySelect = true;     // キーの多重処理防止

    void Start()
    {
        
    }
        // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        if (OnlySelect == true)
        {
            FadeManager.Instance.LoadScene("stage" + stagenumber, 2);
            OnlySelect = false;
        }
    }

}
