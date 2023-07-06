using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController : MonoBehaviour
{
    Vector3 Player;
    GameObject Enemy;
    

    // Start is called before the first frame update
    void Start()
    {
        //プレイヤーのオブジェクトを取得
        Enemy = GameObject.Find("player");


        Player = new Vector2();

    }

    // Update is called once per frame
    void Update()
    {
        //プレイヤーに向かうベクトルの作成
        Player =Enemy.transform.position -this.transform.position;
        Player = Player.normalized;
        //自分自身をプレイヤーに向けて移動
        this.transform.position +=  Player / 200;
    }

    
    
}
