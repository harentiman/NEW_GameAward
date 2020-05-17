using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageSelect : MonoBehaviour
{
    public Button button;
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
        s=button.name.ToString();
        s=s.Substring(s.Length - 3, 3);
        Debug.Log(s);
        FadeManager.Instance.LoadScene("stage-" + s, 2f);
    }
}
