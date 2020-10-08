using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Rotate : MonoBehaviour
{
    private GameObject player;       //プレイヤー格納用
    // Start is called before the first frame update
    void Start()
    {
        //プレイヤーのゲームオブジェクトを入れる
        player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {   //右スティック認識（カメラ移動）
        float angleH = Input.GetAxis("Horizontal2") * 5.0f;
        float angleV = Input.GetAxis("Vertical2");

        //主人公モデルを中心に横に回転
        if (angleH >= 1)
        {
            transform.RotateAround(player.transform.position, Vector3.up, -5f);
        }
        else if (angleH <= -1)
        {
            transform.RotateAround(player.transform.position, Vector3.up, 5f);
        }
        ////主人公モデルを中心に縦に回転
        //else if (angleV >= 0)   
        //{
        //    transform.RotateAround(player.transform.position, Vector3.right , -5f);
        //}
        //else if (angleV <= 0)
        //{
        //    transform.RotateAround(player.transform.position, Vector3.right, 5f);
        //}

    }
}
