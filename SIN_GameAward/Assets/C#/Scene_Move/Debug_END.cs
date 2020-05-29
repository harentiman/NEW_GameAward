using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Debug_END : MonoBehaviour
{

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            FadeManager.Instance.LoadScene("StageSelect", 2);
        }
    }

}
