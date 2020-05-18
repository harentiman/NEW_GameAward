using UnityEngine;
using System.Collections;

// 自動で消える
public class Tutorial_UI : MonoBehaviour
{

    public float timer = 5.0f;
    void Start()
    {
    
    }

    void Update()
    {
        if (Input.anyKey)
        {
            Destroy(gameObject, timer);
        }
    }

}
