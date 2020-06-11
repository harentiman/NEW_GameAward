using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TITLE : MonoBehaviour
{

    bool OnlySelect = true;     // キーの多重処理防止

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OnlySelect == true)
        {
            if (Input.anyKey)
            {
                FadeManager.Instance.LoadScene("StageSelect", 1);
                OnlySelect = false;
            }
        }
    }

}
