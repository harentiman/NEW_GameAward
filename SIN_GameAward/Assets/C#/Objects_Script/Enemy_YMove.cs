using UnityEngine;

public class Enemy_YMove : MonoBehaviour
{

    Vector3 pos;                                     // 現在の位置
    Vector3 rotation;
    //[SerializeField] private float X_delta = 5.0f;   // 左右移動距離
    [SerializeField] private float Y_delta = 5.0f;   // 上下移動距離
    [SerializeField] private float speed = 5.0f;     // 移動速度

    void Start()
    {
        pos = transform.position;
    }

    void Update()
    {
        Vector3 v = pos;
        //v.x += X_delta * Mathf.Sin(Time.time * speed);
        v.y += Y_delta * Mathf.Cos(Time.time * speed);
        transform.position = v;

        //if (X_delta * Mathf.Cos(Time.time * speed) >= 0)
        //{
        //    transform.rotation = Quaternion.Euler(new Vector3(0, 90, 0));

        //}
        //else if (X_delta * Mathf.Cos(Time.time * speed) <= 0)
        //{
        //    transform.rotation = Quaternion.Euler(new Vector3(0, -90, 0));

        //}

        if (Y_delta * Mathf.Sin(Time.time * speed) >= 0)
        {
            transform.rotation = Quaternion.Euler(new Vector3(90, 90, 0));
            Debug.Log("ssddddd");

        }
        else if (Y_delta * Mathf.Sin(Time.time * speed) <= 0)
        {
            transform.rotation = Quaternion.Euler(new Vector3(-90, 90, 0));
            Debug.Log("aaaaaa");

        }


    }

}
