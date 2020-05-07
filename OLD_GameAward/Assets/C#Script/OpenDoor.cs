using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Pressuresensitivity.OpenDoor == true)
        {
            animator.SetTrigger("isOpenDoor");
            Pressuresensitivity.OpenDoor = false;
        }
        else if(Pressuresensitivity.CloseDoor == true)
        {
            animator.SetTrigger("isCloseDoor");
            Pressuresensitivity.CloseDoor = false;
        }
        else if(Pressuresensitivity.OpenDoor == false&& Pressuresensitivity.CloseDoor == false)
        {
            animator.SetTrigger("isIdleDoor");

        }




    }
}