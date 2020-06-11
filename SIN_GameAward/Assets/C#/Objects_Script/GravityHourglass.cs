using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GravityHourglass : MonoBehaviour
{

    public Image Hourglassj;
    public static bool roop;
    float countTime = 3; // クールタイムゲージのカウントを変更
    float speed = 2f;
    float step;

    // Start is called before the first frame update
    void Start()
    {
        //Hourglassj.enabled = false;
        //Hourglassj.fillAmount = 1.0f;
        Hourglassj = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (roop)
        {
            //Hourglassj.enabled = true;
            //Reduce fill amount over 30 seconds
            Hourglassj.fillAmount = 1.0f;
            step = speed * Time.deltaTime;
           // Hourglassj.transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, 180f), step);
            //UIobj.rectTransform.rotation.z
        }
        //if (Hourglassj.rectTransform.rotation.z >= 180)
        //{
        //    Hourglassj.enabled = false;
        //    Debug.Log("ahaha");
        //    //StartCoroutine("Gauge");
        //    roop = false;
        //    Hourglassj.fillAmount = 0;
        //}
    }

}