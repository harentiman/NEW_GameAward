using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    [SerializeField] AudioSource _audio = null;

    void Start()
    {

    }
    void OnCollisionEnter(Collision col)
    {
        if ((col.gameObject.tag == "Retrys") || (col.gameObject.tag == "Enemys"))
        {
            //AudioSource.PlayClipAtPoint(_audio.clip, transform.position);
            FadeManager.Instance.LoadScene(SceneManager.GetActiveScene().name, 2);
            Destroy(this.gameObject);
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "REnemy")
        {
            AudioSource.PlayClipAtPoint(_audio.clip, transform.position);
            FadeManager.Instance.LoadScene(SceneManager.GetActiveScene().name, 2);
            Destroy(this.gameObject);
        }
    }

}