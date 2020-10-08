using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Come_out_naturally_Bubbles : MonoBehaviour
{
    //自然にバブル発射装置から出てくるバブルの種類
    public GameObject Bubble;
    //バブルを飛ばす位置取得
    public Transform Pos;
    // ランダムな値を取得するための変数（初期化は数字で）
    float random_time = 50.0f;

    //バブルゲージを管理しているスクリプトが完成次第、下のコメントを外し【AnotherScript】をバブルゲージを管理しているスクリプト名に変えること
    /*public AnotherScript anotherScript;*/

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //ランダムで設定された数値が０以下の時自然発生させる
        if (random_time <= 0)
        {
            // バブルの複製
            GameObject Bublles = Instantiate(Bubble) as GameObject;

            //当たり判定にベクトル情報を入れる
            Bublles.GetComponent<Rigidbody>().AddForce(Vector3.up * 100);

            // 弾丸の位置を調整
            Bublles.transform.position = Pos.position;
            //ランダムな値に初期化(最低値10,最高値300)
            //バブルゲージの値によって自然発生させる量を変える
          /*if(anotherScript.Bubble_Gage>=100)
            {
                random_time = Random.Range(10.0f, 300.0f);

            }
            else if (anotherScript.Bubble_Gage >= 70)
            {
                random_time = Random.Range(10.0f, 300.0f);


            }
            else if (anotherScript.Bubble_Gage >= 50)
            {
                random_time = Random.Range(10.0f, 300.0f);


            }
            else if (anotherScript.Bubble_Gage >= 30)
            {
                random_time = Random.Range(10.0f, 300.0f);


            }
            else if (anotherScript.Bubble_Gage >= 10)
            {
                random_time = Random.Range(10.0f, 300.0f);


            }
            */
            random_time = Random.Range(10.0f, 300.0f);

        }
        //出てくるまでの時間を減らす
        random_time -=2.0f;

    }
}
