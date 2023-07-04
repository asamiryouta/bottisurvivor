using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charcontroll : MonoBehaviour
{

    public float playerspeed;//プレイヤーの移動速度
    public float speedx;//縦方向への移動
    public float speedy;//横方向への移動
    bool isleftFlag = false;//左右反転させるための変数

    //キーを押すと、プレイヤーが移動する
    void Update()
    {
        //常に行う処理
        speedx = 0;//何も入力していない場合は止まる
        speedy = 0;//何も入力していない場合は止まる



        if (Input.GetKey("d"))//dキーを入力した場合
        {
            speedx = playerspeed;//右方向に進む
            isleftFlag = false;//向きを右にする
        }
        if (Input.GetKey("a"))//aキーを入力した場合
        {
            speedx = -playerspeed;//左方向に進む
            isleftFlag = true;//左向きにする
        }
        if (Input.GetKey("w"))//wキーを入力した場合
        {
            speedy = playerspeed;//上方向に進む

        }
        if (Input.GetKey("s"))//sキーを入力した場合
        {
            speedy = -playerspeed;//下方向に進む

        }
        if (Input.GetKey("right"))//→キーを入力した場合
        {
            speedx = playerspeed;//右方向に進む
            isleftFlag = false;//向きを右にする
        }
        if (Input.GetKey("left"))//←キーを入力した場合
        {
            speedx = -playerspeed;//左方向に進む
            isleftFlag = true;//向きを左にする
        }
        if (Input.GetKey("up"))//↑キーを入力した場合
        {
            speedy = playerspeed;//上方向に進む
        }
        if (Input.GetKey("down"))//↓キーを入力した場合
        {
            speedy = -playerspeed;//下方向に進む
        }
    }

    void FixedUpdate()
    {
        //移動する

        this.transform.Translate(speedx / 50, speedy / 50, 0);

        //左右の向きを変える
        this.GetComponent<SpriteRenderer>().flipX = isleftFlag;
    }
}