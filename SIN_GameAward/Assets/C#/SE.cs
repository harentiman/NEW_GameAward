using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class SE : MonoBehaviour
{
    public Slider SESlider;

    // Start is called before the first frame update

    // Update is called once per frame
    public void OnClick()
    {
        SESlider.value = -80;
    }
}
