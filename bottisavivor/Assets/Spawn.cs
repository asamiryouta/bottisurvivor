using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    //プレハブ格納用
    public GameObject EnemyPrefab;
    //　今何人の敵を出現させたか（総数）
    private int numberOfEnemyPrefab;

    //　この場所から出現する敵の数
    int maxNumOfEnemyEnemyPrefab = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.frameCount % 1000 == 0)
        {
            float x = Random.Range(-5.0f, 5.0f);
            float y = Random.Range(-5.0f, 5.0f);
            Vector3 pos = new Vector3(x, y, 0);
            //プレハブを指定位置に生成
            Instantiate(EnemyPrefab, pos , Quaternion.identity);
            //　この場所から出現する最大数を超えてたら何もしない
            if (numberOfEnemyPrefab >= maxNumOfEnemyEnemyPrefab)
            {
                return;
            }
        }

        

    }
}
