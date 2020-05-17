using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class BGM : MonoBehaviour
{
    public Slider BGMSlider;

    public void OnClick()
    {
        BGMSlider.value = -80;
    }
}
