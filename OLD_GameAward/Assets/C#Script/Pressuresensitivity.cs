using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pressuresensitivity : MonoBehaviour
{
    private Animator animator;
    public static bool OpenDoor;
    public static bool CloseDoor;

    // Start is called before the first frame update
    void Start()
    {
        CloseDoor = false;
        OpenDoor = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            OpenDoor = true;

        }
    }
    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            CloseDoor = true;
        }
    }

    

}
