using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Gravity_Icon : MonoBehaviour
{
    public Image gravity_icon;
    float speed = 180f;
    private float time = 0;
    // Start is called before the first frame update
    void Start()
    {
        gravity_icon = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (GravityGauge.roop)
        {
            time += Time.deltaTime;
            float step = speed * Time.deltaTime;
            Debug.Log(step);
            transform.rotation= Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, 180), step);
            gravity_icon.enabled = true;
           
        }
        if (time>=1.2f)
        {
            //Debug.Log("hirama");
            gravity_icon.enabled = false;
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        }
        if (time >= 3f)
        {
            time = 0;
        }
    }
}
