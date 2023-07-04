using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    //変数がカウントダウンになってるけど気にしないで
    //CountUpTime -> CountDownTime
    //TextCountUp -> TextCountDown
    public static float CountDownTime;　　//カウントダウンタイム
    public Text TextCountDown;  //表示用テキストUI

    // Start is called before the first frame update
    void Start()
    {
       CountDownTime = 0.0F;   //カウントダウン開始秒数をセット
    }

    // Update is called once per frame
    void Update()
    {
        //カウントアップタイムを整形して表示
        TextCountDown.text = string.Format("生存時間  : {0.00}", CountDownTime);
        //経過時刻を増やしていく
        CountDownTime += Time.deltaTime;
        
    }
}
