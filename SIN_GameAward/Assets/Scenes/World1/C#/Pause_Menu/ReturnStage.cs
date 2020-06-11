using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReturnStage : MonoBehaviour
{
    public Button ReturnStageButton;

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
        //ReturnStageButton.interactable = false;
        Time.timeScale = 1f;
        Pause.CopyPauseUI.SetActive(!Pause.CopyPauseUI.activeSelf);
    }
}
