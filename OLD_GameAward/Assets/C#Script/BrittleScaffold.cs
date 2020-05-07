using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrittleScaffold : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Destroy");
            Destroy(this.gameObject, 2.0f);
        }

    }

   

   
}
