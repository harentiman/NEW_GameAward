using UnityEngine;

public class Enemy_Move : MonoBehaviour
{

    Vector3 pos;                                     // 現在の位置
    Vector3 rotation;
    public string Move_Mode;
    public float X_delta;   // 左右移動距離
    public float Y_delta;   // 上下移動距離
    public float Speed;     // 移動速度
    
    void Start()
    {
        pos = transform.position;
    }

    void Update()
    {
        Vector3 v = pos;
        v.x += X_delta * Mathf.Sin(Time.time * Speed);
        v.y += Y_delta * Mathf.Cos(Time.time * Speed);
        transform.position = v;

        switch (Move_Mode)
        {
            case "Floar":
                Move_Floar();
                break;

            case "Ceiling":
                Move_Ceiling();
                break;

            case "LeftSide":
                Move_LeftSide();
                break;

            case "RightSide":
                Move_RightSide();
                break;
        }
    }

    private void Move_Floar()
    {
        if (X_delta * Mathf.Cos(Time.time * Speed) >= 0)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 90, 0));

        }
        else if (X_delta * Mathf.Cos(Time.time * Speed) <= 0)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, -90, 0));

        }
    }

    private void Move_Ceiling()
    {
        if (X_delta * Mathf.Cos(Time.time * Speed) >= 0)
        {
            transform.rotation = Quaternion.Euler(new Vector3(180, -90, 0));

        }
        else if (X_delta * Mathf.Cos(Time.time * Speed) <= 0)
        {
            transform.rotation = Quaternion.Euler(new Vector3(180, 90, 0));

        }
    }

    private void Move_LeftSide()
    {
        if (Y_delta * Mathf.Sin(Time.time * Speed) >= 0)
        {
            transform.rotation = Quaternion.Euler(new Vector3(90, 0, 90));

        }
        else if (Y_delta * Mathf.Sin(Time.time * Speed) <= 0)
        {
            transform.rotation = Quaternion.Euler(new Vector3(-90, 0, 90));

        }
    }

    private void Move_RightSide()
    {
        if (Y_delta * Mathf.Sin(Time.time * Speed) >= 0)
        {
            transform.rotation = Quaternion.Euler(new Vector3(90, 180, 90));

        }
        else if (Y_delta * Mathf.Sin(Time.time * Speed) <= 0)
        {
            transform.rotation = Quaternion.Euler(new Vector3(-90, 180, 90));

        }
    }

}
