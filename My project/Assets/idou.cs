using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idou : MonoBehaviour
{

    public float speed = 20; //  スピード : inspectorで指定

    float vx = 0;       //float型x座標
    float vy = 0;       //float型y座標
    bool leftFlag = false;
    //キーを押すと、スプライトが移動する
    void Update()
    {   //ずっと行う
        vx = 0; //float型x座標
        vy = 0; //float型y座標
        if (Input.GetKey("d"))
        {
            vx = speed;
            leftFlag = false;
        }
        if (Input.GetKey("a"))
        {
            vx = -speed;
            leftFlag = true;
        }
        if (Input.GetKey("w"))
        {
            vy = speed;
            
        }
        if (Input.GetKey("s"))
        {
            vy = -speed;
            
        }
        if (Input.GetKey("right"))
        {
            vx = speed;
            leftFlag = false;
        }
        if (Input.GetKey("left"))
        {
            vx = -speed;
            leftFlag = true;
        }
        if (Input.GetKey("up"))
        {
            vy = speed;

        }
        if (Input.GetKey("down"))
        {
            vy = -speed;

        }
        //カーソル位置を取得
       
    }

    void FixedUpdate()
    {
        //移動する

        this.transform.Translate(vx / 50,vy / 50, 0);

        //左右の向きを変える
        this.GetComponent<SpriteRenderer>().flipX = leftFlag;
    }
}
