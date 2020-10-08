using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Auto_destory : MonoBehaviour
{
    //オブジェクトを消すときに作動
    bool _enabled = false;
    //このスクリプトをアタッチしたオブジェクトのレンダーを取得
    Renderer _renderer;
    void Start()
    {
        _renderer = GetComponent<Renderer>();
    }
    void Update()
    {
        //消すやつがfalseでかつカメラの中にレンダラー（オブジェクト内にあるメッシュレンダラーというコンポーネント。要するにマテリアル）が存在しているとき
        if (!_enabled && _renderer.isVisible)
            _enabled = true;
        //消す奴がtureでかつカメラの中にレンダラーが存在しない場合消去
        if (_enabled && !_renderer.isVisible)
            Destroy(gameObject);
    }
}
