using UnityEngine;

public class Enemy_Move : MonoBehaviour
{

    Vector3 pos;                                     // 現在の位置
    [SerializeField] private float X_delta = 5.0f;   // 左右移動距離
    [SerializeField] private float Y_delta = 5.0f;   // 上下移動距離
    [SerializeField] private float speed = 5.0f;     // 移動速度

    void Start()
    {
        pos = transform.position;
    }

    void Update()
    {
        Vector3 v = pos;
        v.x += X_delta * Mathf.Sin(Time.time * speed);
        v.y += Y_delta * Mathf.Sin(Time.time * speed);
        transform.position = v;
    }

}
