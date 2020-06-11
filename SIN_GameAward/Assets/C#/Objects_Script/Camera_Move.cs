using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Move : MonoBehaviour
{

    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Player != null)     // エラー回避用
        {
            Vector3 CameraPos = Player.transform.position;
            //カメラとプレイヤーの位置を同じにする
            transform.position = new Vector3(CameraPos.x, 6, -13);
            transform.rotation = Quaternion.Euler(2, 0, 0);
        }
    }

}
