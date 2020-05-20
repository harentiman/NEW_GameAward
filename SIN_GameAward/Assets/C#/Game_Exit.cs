using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Game_Exit : MonoBehaviour
{

    public Button button;

    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

    }
    public void OnClick()
    {
        Debug.Log("ゲーム終了");
        PlayerPrefs.DeleteAll();

        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #elif UNITY_WEBPLAYER
		        Application.OpenURL("http://www.yahoo.co.jp/");
        #else
		        Application.Quit();
        #endif
    }

}
