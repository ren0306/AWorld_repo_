using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    //プレイヤーの動くスピード
    public float　player_speed;
    private Vector3 latestPos;  //前回のPosition    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //左スティック認識（主人公移動）
        float x = Input.GetAxis("Horizontal") * 5.0f;
        float y = Input.GetAxis("Vertical") * 5.0f;
        //位置情報専用変数にこのオブジェクトの位置情報を入れる
        Transform MYTransform = this.transform;
        //Vector3 diff = MYTransform.position - latestPos;   //前回からどこに進んだかをベクトルで取得
        //latestPos = MYTransform.position;  //前回のPositionの更新

        Vector3 pos = MYTransform.position;

        //主人公の移動
        if (y<=1)
        {
            pos.z -= player_speed;
        }

        if (x<=1)
        {
            pos.x -= player_speed;
            
        }

        if (x>=-1)
        {
            pos.x += player_speed;
        }

        if (y>=-1)
        {
            pos.z += player_speed;
        }


        ////ベクトルの大きさが0.01以上の時に向きを変える処理をする
        //if (diff.magnitude > 0.01f)
        //{
        //    MYTransform.rotation = Quaternion.LookRotation(diff); //向きを変更する
        //}
        MYTransform.position = pos;  // 座標を設定

    }
}
