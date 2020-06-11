using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Fast_Select : MonoBehaviour
{
    private Selectable mySelectable;

    void Start()
    {
        mySelectable = GetComponent<Selectable>();
        mySelectable.Select();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            mySelectable.Select();
        }
    }


}


