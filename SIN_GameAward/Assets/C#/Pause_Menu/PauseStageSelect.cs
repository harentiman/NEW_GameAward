using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseStageSelect : MonoBehaviour
{
    public Button StageSelect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OnClick()
    {
        StageSelect.interactable = false;
        Time.timeScale = 1.0f;

        // Player削除
        GameObject obj = GameObject.Find("Player");
        Destroy(obj);

        FadeManager.Instance.LoadScene("StageSelect", 2f);

        PlayerPrefs.Save();
    }
}
