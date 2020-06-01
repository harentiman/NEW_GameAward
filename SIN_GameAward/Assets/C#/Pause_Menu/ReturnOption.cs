using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnOption : MonoBehaviour
{
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
        Pause.CopyPauseUI.SetActive(!Pause.CopyPauseUI.activeSelf);
        Pause.CopyOptionUI.SetActive(!Pause.CopyOptionUI.activeSelf);
    }
}
