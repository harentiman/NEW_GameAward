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

    public void SetSelectable()
    {
        //　タブキーを押されたらSelectOnRightに選択された物をフォーカスする
        //if (Input.GetKeyDown(KeyCode.S))
        //{
        //    EventSystem.current.SetSelectedGameObject(mySelectable.navigation.selectOnDown.gameObject);
        //}
        //else if(Input.GetKeyDown(KeyCode.D))
        //{
        //    EventSystem.current.SetSelectedGameObject(mySelectable.navigation.selectOnUp.gameObject);
        //}
    }
}


