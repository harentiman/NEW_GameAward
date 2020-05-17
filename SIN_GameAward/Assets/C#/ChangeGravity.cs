﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CustomInputKey;   // 入力制限、３秒間のクールタイム
using UnityEngine.UI;

public class ChangeGravity : MonoBehaviour
{

    public static bool changegravity;
    private Rigidbody rig;
    private Vector3 Gravity;
    bool jumppingFlug = true;           //無限ジャンプ防止

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        Gravity = new Vector3(0,  -9.8f, 0);
        changegravity = false;
    }

    void FixedUpdate()
    {
        // 重力処理
        UseGravity();
        // ジャンプ処理
        if (CustomInput.Interval_InputKeydown(KeyCode.Space,0.5f))
        {
            if (jumppingFlug == true)
            {
                if (changegravity == false)
                {
                    Jump();         // 通常時のジャンプ処理
                }
                else if (changegravity == true)
                {
                    ReturnJump();   // 反転時のジャンプ処理
                }
            }
        }
    }

    void Update()
    {
        if (CustomInput.Interval_InputKeydown(KeyCode.R,3))
        {
            if (changegravity == false)
            {
                GravityGauge.roop = true;
                transform.rotation = Quaternion.AngleAxis(180, new Vector3(0, 0, 1));
                Gravity = new Vector3(0, 9.8f, 0);
                changegravity =true;
                
            }

            else if (changegravity == true)
            {
                GravityGauge.roop = true;
                transform.rotation = Quaternion.AngleAxis(0, new Vector3(0, 0, 1));
                Gravity = new Vector3(0, -9.8f, 0);
                changegravity = false;
                
            }
        }
    }

    void Jump()
    {
        jumppingFlug = false;
        rig.AddForce(Vector3.up * 300);
    }

    void ReturnJump()
    {
        jumppingFlug = false;
        rig.AddForce(Vector3.down * 300);
    }

    private void UseGravity()
    {
        rig.AddForce(Gravity, ForceMode.Acceleration);
    }

    void OnCollisionEnter(Collision col)
    {
        // 無限ジャンプ防止処理
        if ((col.gameObject.tag == "Ground"))
        {
            jumppingFlug = true;
        }
    }
}


