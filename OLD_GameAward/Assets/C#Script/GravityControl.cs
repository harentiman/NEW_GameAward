using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityControl : MonoBehaviour
{
    private Rigidbody rig;
    Vector3 Gravity;

    // Start is called before the first frame update
    void Start()
    {

        rig = GetComponent<Rigidbody>();
        Gravity = new Vector3(0, -600, 0);
    }

    void FixedUpdate()
    {
        UseGravity();
    }   

    void UseGravity()
    {
        rig.AddForce(Gravity, ForceMode.Acceleration);
    }
}
