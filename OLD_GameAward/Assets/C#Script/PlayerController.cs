using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public static Rigidbody rb;
    float playerspeed;
    float jampsSpeed;
    public static bool isJumping;
    float Horizontal = 0f;

    


    // Start is called before the first frame update
    void Start()
    {
        playerspeed = 10.0f;
        isJumping = false;
        jampsSpeed = 5700.0f;
        rb = GetComponent<Rigidbody>();

        //rig.useGravity = false;

    }

    // Update is called once per frame
    void Update()
    {


        Horizontal = Input.GetAxis("Horizontal");

        Vector3 direction = new Vector3(Horizontal, 0, 0);

        if (isJumping == true)
        {


            if (Input.GetKey(KeyCode.X) || Input.GetKeyDown("joystick button 0"))
            {
                Debug.Log("isjamping");
                rb.AddForce(transform.up * jampsSpeed);
                isJumping = false;
            }
        }

        if (RayCast.Hit == true&& Input.GetKeyDown("joystick button 2")) 
        {
            transform.parent = GameObject.Find("WoodenBox").transform;
        }
        else
        {
            transform.parent = null;
        }
    }


    void FixedUpdate()
    {
        rb.velocity = new Vector3(Horizontal*playerspeed, 0, 0);
        
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Stage"))
        {
            isJumping = true;
        }

    }
}

