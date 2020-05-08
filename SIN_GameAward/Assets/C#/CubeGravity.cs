using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CustomInputKey;   // 入力制限、３秒間のクールタイム

public class CubeGravity : MonoBehaviour
{

    private Rigidbody rig;
    private Vector3 Gravity;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        Gravity = new Vector3(0, -9.8f, 0);
    }

    void FixedUpdate()
    {
        UseGravity();
    }

    // Update is called once per frame
    void Update()
    {
        if (ChangeGravity.changegravity == true)
        {
            Gravity = new Vector3(0, 9.8f, 0);

        }
        else if (ChangeGravity.changegravity == false)
        {
            Gravity = new Vector3(0, -9.8f, 0);
        }
    }

    private void UseGravity()
    {
        rig.AddForce(Gravity, ForceMode.Acceleration);
    }

}