using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble_Destroy : MonoBehaviour
{
    //　出現させるエフェクト
    [SerializeField]
    private GameObject effectObject;
    //　エフェクトを消す秒数
    [SerializeField]
    private float deleteTime;
    //　エフェクトの出現位置のオフセット値
    [SerializeField]
    private float offset;
    Rigidbody Bubble_rb;
    Quaternion q1 = Quaternion.Euler(0f, 0f, 0f); // 回転A
    Quaternion q2 = Quaternion.Euler(0f, 0f, 90f); // 回転B
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        //バブルが当たると消えるタグ
        if (col.gameObject.tag == "Not_Hit_Bubble")
        {
            //　ゲームオブジェクト登場時にエフェクトをインスタンス化
            var instantiateEffect = GameObject.Instantiate(effectObject, transform.position + new Vector3(0f, offset, 0f), Quaternion.Euler(-90,0,0)) as GameObject;
            Destroy(instantiateEffect, deleteTime);
            this.gameObject.SetActive(false);
        }
        //箱判定のものに当たるとくっつくようにする
        else if(col.gameObject.tag=="Box")
        {
            //（）の中に入っている名前のオブジェクトを探す
            transform.parent = GameObject.Find("enemy").transform;
            Rigidbody B_rb = this.gameObject.GetComponent<Rigidbody>();
            B_rb.isKinematic = true;
        }
    }

}
