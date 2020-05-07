using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
    public static bool Hit;

    // Start is called before the first frame update
    void Start()
    {
       
        //Rayの飛ばせる距離
    }

    // Update is called once per frame
    void Update()
    {
        ray = new Ray(transform.position, -transform.right);

        if (Physics.Raycast(ray, out hit, 1.0f))
        {
            Debug.Log(hit.collider.gameObject.transform.position);

            if (hit.collider.gameObject.name == ("Player"))
            {
                WoodenBox.rb.constraints = RigidbodyConstraints.None;
                WoodenBox.rb.constraints = RigidbodyConstraints.FreezeRotation | RigidbodyConstraints.FreezePositionZ;


                Hit = true;
                Debug.Log(true);
            }
            else
            {
                WoodenBox.rb.constraints = RigidbodyConstraints.None;
                WoodenBox.rb.constraints = RigidbodyConstraints.FreezeRotation | RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ;
            }

        }
        Debug.DrawRay(ray.origin, ray.direction * 1, Color.red, 5);

    }
}
