﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{

    [SerializeField] private Vector3 velocity;              // 移動方向
    [SerializeField] private float moveSpeed = 5.0f;        // 移動速度
    bool MoveFlug = true;                                   // 移動制限
    void Start()
    {

    }


    void Update()
    {
        //Debug.Log(Input.GetAxis("Horizontal"));
        //Debug.Log(Input.GetJoystickNames()[0]=="");

        // AD入力から、X平面(水平な地面)を移動する方向(velocity)を得ます
        velocity = Vector3.zero;

        // 左右移動

        if (MoveFlug == true && ChangeGravity.changegravity == true)
        {
            if (Input.GetKey(KeyCode.A)) //|| Input.GetAxis("Horizontal") < 0)
            {
                transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
                velocity.x += 1;
            }
            if (Input.GetKey(KeyCode.D)) //|| Input.GetAxis("Horizontal") > 0)
            {
                transform.rotation = Quaternion.Euler(new Vector3(0, -180, 0));
                velocity.x -= 1;
            }
           
        }
        if (MoveFlug == true && ChangeGravity.changegravity == false)
        {
            if (Input.GetKey(KeyCode.A)) //|| Input.GetAxis("Horizontal") < 0)
            {
                transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
                velocity.x -= 1;
            }
               
            if (Input.GetKey(KeyCode.D)) //|| Input.GetAxis("Horizontal") > 0)
            {
                transform.rotation = Quaternion.Euler(new Vector3(0, -180, 0));
                velocity.x += 1;
            }
                
        }

         // 速度ベクトルの長さを1秒でmoveSpeedだけ進むように調整します
         velocity = velocity.normalized * moveSpeed * Time.deltaTime;

        // いずれかの方向に移動している場合
        if (velocity.magnitude > 0)
        {
            // プレイヤーの位置(transform.position)の更新
            // 移動方向ベクトル(velocity)を足し込みます
            transform.position += velocity;
        }
    }
    void OnCollisionEnter(Collision col)
    {
        // リトライ時に消滅（操作不能）
        if ((col.gameObject.tag == "Retrys") || (col.gameObject.tag == "Enemys"))
        {
            Destroy(this.gameObject);
            GameObject obj = GameObject.FindGameObjectWithTag("Enemys");
            Destroy(obj);

        }
        // ゴール時、操作不能
        if ((col.gameObject.tag == "Goal"))
        {
            MoveFlug = false;
        }
    }

}