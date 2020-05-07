using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InversAnimation : MonoBehaviour
{
    //定義
    private Animator animator;
    private bool isInvers;
    private bool isReInvers;
    private bool isIdle;
    private float freezetime;
    private float speed = 500f;


    // Start is called before the first frame update
    void Start()
    {
        //初期化
        animator = GetComponent<Animator>();
        isInvers = true;
        isReInvers = true;
        freezetime = 1.0f;

    }
    // Update is called once per frame
    void Update()
    {
        //ジャンプ可
        if (PlayerController.isJumping == true)
        {
            //回転
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown("joystick button 3") && isInvers == true)
            {

                PlayerController.rb.constraints = RigidbodyConstraints.FreezeAll;  //全固定
                float step = speed * Time.deltaTime;


                animator.SetTrigger("isInvers");                                    //アニメーション
                Invoke("Freeze", freezetime);                                       //遅延処理
                PlayerController.rb.transform.rotation = Quaternion.Euler(0, 0, 180f);
                isInvers = false;
                Debug.Log("Invers");

            }
            //再回転
            else if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown("joystick button 3") && isReInvers == true)
            {
                PlayerController.rb.constraints = RigidbodyConstraints.FreezeAll;
                animator.SetTrigger("isReInvers");
                Invoke("Freeze", freezetime);
                PlayerController.rb.transform.rotation = Quaternion.Euler(0, 0, 180f);
                isReInvers = false;
                Debug.Log("Invers");


            }
            //通常
            else if (isInvers == false && isReInvers == false)
            {

                PlayerController.rb.constraints = RigidbodyConstraints.FreezeAll;
                animator.SetTrigger("isIdle");
                Invoke("Freeze", freezetime);
                isInvers = true;
                isReInvers = true;


            }
        }
    }

    //フリーズ処理
    private void Freeze()
    {
        PlayerController.rb.constraints = RigidbodyConstraints.None;           //固定解除
        PlayerController.rb.constraints = RigidbodyConstraints.FreezeRotation;
    }
}
