using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble_Shot : MonoBehaviour
{

    //飛ばすバブルの種類
    public GameObject Bublle;
    //バブルを飛ばす位置取得
    public Transform Pos;
    //バブルの速度
    public float speed = 1000;

    float time = 100;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //L2（エイム）
        if (Input.GetKeyDown("joystick button 6"))
        {
            Debug.Log("button6");
        }
        //R2（発射）
        //if(Input.GetKeyDown("joystick button 7"))
        //{
        if (Input.GetKeyDown(KeyCode.Z))
        {
            // バブルの複製
            GameObject Bublles = Instantiate(Bublle) as GameObject;
            Vector3 force;
            //このスクリプトをアタッチしたゲームオブジェクトの前に出現させ、スピードの値分前進させる
            force = this.gameObject.transform.forward * speed;

            //当たり判定にベクトル情報を入れる
            Bublles.GetComponent<Rigidbody>().AddForce(force);

            // 弾丸の位置を調整
            Bublles.transform.position = Pos.position;
            time = 100;
        }
        else
            time--;
        //}



    }

}
