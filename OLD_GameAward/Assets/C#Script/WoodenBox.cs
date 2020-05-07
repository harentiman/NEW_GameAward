using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodenBox : MonoBehaviour
{
    public static Rigidbody rb;
   

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Pressuresensitivity"))
        {
            Pressuresensitivity.OpenDoor = true;

        }
    }
    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.CompareTag("Pressuresensitivity"))
        {
            Pressuresensitivity.CloseDoor = true;
        }
    }
}
