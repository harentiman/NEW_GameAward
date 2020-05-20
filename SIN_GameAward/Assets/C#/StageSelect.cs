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

    void Start()
    {
        
    }
        // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        FadeManager.Instance.LoadScene("stage" + stagenumber, 2);
    }
}
