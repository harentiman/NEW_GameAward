using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Option : MonoBehaviour
{
    public GameObject pause;
    public GameObject option;
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
        option.SetActive(true);
        pause.SetActive(false);
        mySelectable.Select();
        Debug.Log("option");
    }
}
