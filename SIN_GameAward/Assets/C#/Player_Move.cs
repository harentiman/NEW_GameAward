using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{

    [SerializeField] private Vector3 velocity;              // 移動方向
    [SerializeField] private float moveSpeed = 5.0f;        // 移動速度

    void Update()
    {
        // AD入力から、X平面(水平な地面)を移動する方向(velocity)を得ます
        velocity = Vector3.zero;

        // 左右移動
        if (Input.GetKey(KeyCode.A))
            velocity.x -= 1;
        if (Input.GetKey(KeyCode.D))
            velocity.x += 1;

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

    // リトライ時に消滅（操作不能）
    void OnCollisionEnter(Collision col)
    {
        if ((col.gameObject.tag == "Retrys") || (col.gameObject.tag == "Enemys"))
        {
            Destroy(this.gameObject);
        }
    }

    //public float speed = 10f;
    //float moveX = 0f;

    //Rigidbody rb;

    //void Start()
    //{
    //    rb = GetComponent<Rigidbody>();
    //}

    //void Update()
    //{
    //    moveX = Input.GetAxis("Horizontal") * speed;
    //    Vector3 direction = new Vector3(moveX, 0, 0);
    //}

    //void FixedUpdate()
    //{
    //    rb.velocity = new Vector3(moveX, 0,0);
    //}

}