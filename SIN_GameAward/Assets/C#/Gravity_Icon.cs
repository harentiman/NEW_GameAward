using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Gravity_Icon : MonoBehaviour
{
    public Image gravity_icon;
    float speed = 120f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (GravityGauge.roop)
        {
            float step = speed * Time.deltaTime;
            transform.rotation= Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, 180), step);
            gravity_icon.enabled = true;
           
        }
        if (!GravityGauge.roop)
        {
            gravity_icon.enabled = false;
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));

        }
    }
}
