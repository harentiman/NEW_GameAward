using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ReturnOption : MonoBehaviour
{

    public Selectable mySelectable;

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
        Pause.CopyPauseUI.SetActive(true);
        Pause.CopyOptionUI.SetActive(false);
        mySelectable.Select();
    }
}
