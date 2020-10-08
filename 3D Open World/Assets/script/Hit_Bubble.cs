using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit_Bubble : MonoBehaviour
{
    float time = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if(!this.gameObject.activeSelf)
        //{
        //    if(time<=0)
        //    {
        //        this.gameObject.SetActive(true);
        //        time = 10;
        //    }

        //    time--;

        //}
    }

    void OnTriggerEnter(Collider col)
    {
        //バブルに当たるとバブルに閉じ込める
        if (col.gameObject.tag == "Bubble")
        {
            this.gameObject.SetActive(false);
        }
    }
}
