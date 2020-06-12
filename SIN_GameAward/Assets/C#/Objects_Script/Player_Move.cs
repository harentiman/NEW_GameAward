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
    public GameObject obj;
    Vector3 OldPos;
    private bool RightCheck=false;
    private bool LeftCheck=false;
 
    void Start()
    {
        animator = obj.GetComponent<Animator>();
    }
   

    void FixedUpdate()
    {
        OldPos = this.transform.position;
        // AD入力から、X平面(水平な地面)を移動する方向(velocity)を得ます
        velocity = Vector3.zero;

        // 左右移動

        if (MoveFlug == true && ChangeGravity.changegravity == true)
        {
            if (Input.GetKey(KeyCode.A)|| Input.GetAxis("Horizontal") < -0.1)
            {
                animator.SetBool("iswalk", true);
                transform.rotation = Quaternion.Euler(new Vector3(180, 0, 0));
                if(LeftCheck==false)
                {
                    velocity.x += 1;
                }
                



            }
            else if (Input.GetKey(KeyCode.D)|| Input.GetAxis("Horizontal") > 0.1)
            {
                
                animator.SetBool("iswalk", true);
                transform.rotation = Quaternion.Euler(new Vector3(180, 180, 0));

                if (RightCheck== false)
                {
                    velocity.x -= 1;
                }

            }
        }
       
        else if (MoveFlug == true && ChangeGravity.changegravity == false)
        {

            if (Input.GetKey(KeyCode.A)|| Input.GetAxis("Horizontal") < -0.1)
            {
                animator.SetBool("iswalk", true);
                transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
                if (RightCheck == false)
                {
                    velocity.x -= 1;
                }
            }

            else if (Input.GetKey(KeyCode.D)|| Input.GetAxis("Horizontal") > 0.1)
            {
                animator.SetBool("iswalk", true);
                transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
                if (LeftCheck == false)
                {
                    velocity.x += 1;
                }
            }
            else
            {
                animator.SetBool("iswalk", false);

            }
        }
        // 速度ベクトルの長さを1秒でmoveSpeedだけ進むように調整します
        velocity = velocity.normalized * moveSpeed * Time.fixedDeltaTime;

        // いずれかの方向に移動している場合
        if (velocity.magnitude > 0)
        {
            // プレイヤーの位置(transform.position)の更新
            // 移動方向ベクトル(velocity)を足し込みます
            transform.position += velocity;
        }

        LeftCheck = false;
        RightCheck = false;

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

    void OnCollisionStay(Collision col)
    {
        if (col.gameObject.CompareTag("Ground"))
        {
            Vector3 distans = this.transform.position - col.transform.position;
           

            if (Mathf.Abs(distans.x) < (this.transform.lossyScale.x/2)+0.5&&Mathf.Abs(distans.y)< (this.transform.lossyScale.y / 2 + 1.0)*0.8)
            {
                if (distans.x < 0)
                {
                    LeftCheck = true;
                }
                else if(distans.x > 0)
                {
                    RightCheck = true;
                }
                this.transform.position = new Vector3(OldPos.x, this.transform.position.y, this.transform.position.z);
            }
            else
            {
               
            }
            //if (Mathf.Abs(distans.y) < (this.transform.lossyScale.y/2)+1.0&& Mathf.Abs(distans.x) < (this.transform.lossyScale.x / 2 + 0.4)*0.8)
            //{
                
            //    this.transform.position = new Vector3(this.transform.position.x,OldPos.y, this.transform.position.z);
            //}
            //else
            //{
                
            //}
        }


    }

}