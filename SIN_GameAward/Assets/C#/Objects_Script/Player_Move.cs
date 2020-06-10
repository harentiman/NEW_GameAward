using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CustomInputKey.CustomInputKey2;   // ジャンプ1秒クールタイム

public class Player_Move : MonoBehaviour
{

    [SerializeField] private Vector3 velocity;              // 移動方向
    [SerializeField] private float moveSpeed = 5.0f;        // 移動速度
    bool MoveFlug = true;                                   // 移動制限
    public Animator animator;


    void Start()
    {

    }


    void Update()
    {
        //animator.SetBool("isIdle",true);
       

        //Debug.Log(Input.GetAxis("Horizontal"));
        //Debug.Log(Input.GetJoystickNames()[0]=="");

        // AD入力から、X平面(水平な地面)を移動する方向(velocity)を得ます
        velocity = Vector3.zero;

        // 左右移動

        if (MoveFlug == true && ChangeGravity.changegravity == true)
        {
            if (Input.GetKey(KeyCode.A)|| Input.GetAxis("Horizontal") < 0.1)
            {
                animator.SetBool("iswalk", true);
                transform.rotation = Quaternion.Euler(new Vector3(180, -90, 0));
                velocity.x += 1;
               

            }
            if (Input.GetKey(KeyCode.D)|| Input.GetAxis("Horizontal") > 0.1)
            {
                animator.SetBool("iswalk", true);
                transform.rotation = Quaternion.Euler(new Vector3(180, 90, 0));
                velocity.x -= 1;
               

            }

        }
        else
        {
            animator.SetBool("iswalk", false);
        }

        if (MoveFlug == true && ChangeGravity.changegravity == false)
        {
            if (Input.GetKey(KeyCode.A)|| Input.GetAxis("Horizontal") < 0.1)
            {
                animator.SetBool("iswalk", true);
                transform.rotation = Quaternion.Euler(new Vector3(0, -90, 0));
                velocity.x -= 1;
               
            }

            if (Input.GetKey(KeyCode.D)|| Input.GetAxis("Horizontal") > 0.1)
            {
                animator.SetBool("iswalk", true);
                transform.rotation = Quaternion.Euler(new Vector3(0, 90, 0));
                velocity.x += 1;
                

            }

        }
        else
        {
            animator.SetBool("iswalk",false);
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
           
            // Player削除
            Destroy(this.gameObject);
            Enemy_Move.isMove = false;
        }

        // ゴール時、操作不能
        if ((col.gameObject.tag == "Goal"))
        {
            MoveFlug = false;
        }
    }

}