using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GravityGauge : MonoBehaviour
{
    
    public Image UIobj;
    public static bool roop;
    float countTime = 3.0f; 

    // Start is called before the first frame update
    void Start()
    {
        UIobj.fillAmount = 0.0f;
    }

  // Update is called once per frame
    void Update()
    {
       
        if (roop)
        {
            //Reduce fill amount over 30 seconds
            UIobj.fillAmount += 1.0f / countTime * Time.deltaTime;
        }
        if (UIobj.fillAmount == 1)
        {
           // StartCoroutine("Gauge");
            roop = false;
            UIobj.fillAmount = 0;
        }
    }

}


