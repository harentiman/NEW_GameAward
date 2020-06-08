﻿using System.Collections;
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
    public Animator Player;

    public AudioClip sound1;
    public AudioClip sound2;

    AudioSource AudioSource;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        Gravity = new Vector3(0,  -9.8f, 0);
        changegravity = false;
        AudioSource = GetComponent<AudioSource>();
    }

    void FixedUpdate()
    {
        // 重力処理
        if (gravityFlug == true)
        {
            UseGravity();
        }

        // ジャンプ処理
        if (CustomInput2.Interval_InputKeydown2(KeyCode.Space,0.5f)) // ジャンプ後、クールタイム
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
                    transform.rotation = Quaternion.AngleAxis(180, new Vector3(0, 0, 1));
                    Gravity = new Vector3(0, 9.8f, 0);
                    transform.rotation = Quaternion.AngleAxis(180, new Vector3(0, 0, 1));
                    changegravity = true;
                    AudioSource.PlayOneShot(sound2);
                }

                else if (changegravity == true)
                {
                   
                    animator.SetTrigger("isCameraReRotation");
                    animator.SetTrigger("isIdle");
                    GravityGauge.roop = true;
                    Gravity = new Vector3(0, -9.8f, 0);
                    transform.rotation = Quaternion.AngleAxis(0, new Vector3(0, 0, 1));

                    changegravity = false;
                    AudioSource.PlayOneShot(sound2);
                }
            }
        }
    }

    void Jump()
    {
        Player.SetBool("isjump", true);
        jumppingFlug = false;
        rig.AddForce(Vector3.up * 280);
        StartCoroutine("jump");


    }

    void ReturnJump()
    {
        Player.SetBool("isjump", true);
        jumppingFlug = false;
        StartCoroutine("jump");
        animator.SetBool("isjump", false);

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
            animator.SetBool("isjump", false);
            Debug.Log("isjump   true");
            jumppingFlug = true;
            AudioSource.PlayOneShot(sound1);
        }
        // ゴール時、操作不能
        if ((col.gameObject.tag == "Goal"))
        {
            jumppingFlug = false;
            gravityFlug = false;
        }
    }
    IEnumerator jump()
    {
        yield return new WaitForSeconds(1);
        rig.AddForce(Vector3.down * 280);
    }



}


