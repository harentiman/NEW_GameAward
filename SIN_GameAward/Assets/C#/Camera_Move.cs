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
        Vector3 CameraPos = Player.transform.position;
        //カメラとプレイヤーの位置を同じにする
        transform.position = new Vector3(CameraPos.x, 6, -17);
    }

}
