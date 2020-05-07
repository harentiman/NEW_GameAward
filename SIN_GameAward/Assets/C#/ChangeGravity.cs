using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CustomInputKey;   // 入力制限、３秒間のクールタイム
using UnityEngine.UI;

public class ChangeGravity : MonoBehaviour
{

   

    public static bool changegravity;
    private Rigidbody rig;
    private Vector3 Gravity;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        Gravity = new Vector3(0,  -9.8f, 0);
        changegravity = false;
    }

    void FixedUpdate()
    {
        UseGravity();
    }

    void Update()
    {
        if (CustomInput.Interval_InputKeydown(KeyCode.Space, 3))
        {
            if (changegravity == false)
            {
                GravityGauge.roop = true;
                transform.rotation = Quaternion.AngleAxis(180, new Vector3(0, 0, 1));
                Gravity = new Vector3(0, 9.8f, 0);
                changegravity =true;
                GravityGauge.roop = false;
            }

            else if (changegravity == true)
            {
                GravityGauge.roop = true;
                transform.rotation = Quaternion.AngleAxis(0, new Vector3(0, 0, 1));
                Gravity = new Vector3(0, -9.8f, 0);
                changegravity = false;
                GravityGauge.roop = false;


            }

        }
    }

    private void UseGravity()
    {
        rig.AddForce(Gravity, ForceMode.Acceleration);
    }

}


