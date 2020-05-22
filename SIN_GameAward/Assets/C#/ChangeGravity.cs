using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CustomInputKey;                   // 重力反転3秒クールタイム 
using CustomInputKey.CustomInputKey2;   // ジャンプ1秒クールタイム
using UnityEngine.UI;

public class ChangeGravity : MonoBehaviour
{

    public static bool changegravity;
    private Rigidbody rig;
    private Vector3 Gravity;
    public static bool jumppingFlug = true;           //無限ジャンプ防止
    bool gravityFlug = true;                          //重力操作制
    public Animator animator;

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
        if (gravityFlug == true)
        {
            UseGravity();
        }

        // ジャンプ処理
        if (CustomInput2.Interval_InputKeydown2(KeyCode.Space,1)) // ジャンプ後、1fのクールタイム
        //if (Input.GetKeyDown(KeyCode.Space))
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
        if (gravityFlug == true)
        {
            if (CustomInput.Interval_InputKeydown(KeyCode.R, 3)) // 反転後、3fのクールタイム
            {
                if (changegravity == false)
                {
                    animator.SetTrigger("isCameraRotation");
                    GravityGauge.roop = true;
                    //transform.rotation = Quaternion.AngleAxis(180, new Vector3(0, 0, 1));
                    Gravity = new Vector3(0, 9.8f, 0);
                    changegravity = true;

                }

                else if (changegravity == true)
                {
                    animator.SetTrigger("isCameraReRotation");
                    animator.SetTrigger("isIdle");
                    GravityGauge.roop = true;
                    //transform.rotation = Quaternion.AngleAxis(0, new Vector3(0, 0, 1));
                    Gravity = new Vector3(0, -9.8f, 0);
                    changegravity = false;

                }
            }
        }
    }

    void Jump()
    {
        jumppingFlug = false;
        rig.AddForce(Vector3.up * 250);

    }

    void ReturnJump()
    {
        jumppingFlug = false;
        rig.AddForce(Vector3.down * 250);
    }

    private void UseGravity()
    {
        rig.AddForce(Gravity, ForceMode.Acceleration);
    }

    void OnCollisionEnter(Collision col)
    {
        // 無限ジャンプ防止
        if ((col.gameObject.tag == "Ground"))
        {
            jumppingFlug = true;
        }
        // ゴール時、操作不能
        if ((col.gameObject.tag == "Goal"))
        {
            jumppingFlug = false;
            gravityFlug = false;
        }
    }

}


