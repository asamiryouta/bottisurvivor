using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    Vector3 p;
    GameObject g;
    

    // Start is called before the first frame update
    void Start()
    {
        //プレイヤーのオブジェクトを取得
        g = GameObject.Find("player");


        p = new Vector2();

    }

    // Update is called once per frame
    void Update()
    {
        //プレイヤーに向かうベクトルの作成
        p =g.transform.position -this.transform.position;
        //自分自身をプレイヤーに向けて移動
        this.transform.position += p / 50;
    }

    
    
}
