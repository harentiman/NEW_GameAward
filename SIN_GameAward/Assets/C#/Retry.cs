using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{

    void OnCollisionEnter(Collision col)
    {
        if ((col.gameObject.tag=="Retrys") || (col.gameObject.tag == "Enemys"))
        {
            FadeManager.Instance.LoadScene("SampleScene", 2);
        }
    }

}