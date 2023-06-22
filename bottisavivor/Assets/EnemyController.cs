using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private GameObject playerObject;    //プレイヤーオブジェクト
    private Vector3 PlayerPosition;     //プレイヤーの位置情報
    private Vector3 EnemyPosition;      //敵の位置情報

    // Start is called before the first frame update
    void Start()
    {
        playerObject = GameObject.FindWithTag("player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
