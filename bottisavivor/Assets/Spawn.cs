using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    //プレハブ格納用
    public GameObject EnemyPrefab;


    int count;

    // Update is called once per frame
    void FixedUpdate()
    {
        count++;
        if (count < 50)
        {

            float xleft = Random.Range(-202.0f,-158.0f);
            float yleft = Random.Range(-70.0f, 70.0f);
            Vector3 posleft = new Vector3(xleft, yleft, 0);
            float xright = Random.Range(158.0f, 178.0f);
            float yright = Random.Range(-70.0f, 70.0f);
            Vector3 posright = new Vector3(xright, yright, 0);
            float xtop = Random.Range(-150.0f, 190.0f);
            float ytop = Random.Range(63.0f, 100.0f);
            Vector3 postop = new Vector3(xtop, ytop, 0);
            float xunder = Random.Range(-178.0f, 158.0f);
            float yunder = Random.Range(-90.0f, -70.0f);
            Vector3 posunder = new Vector3(xunder, yunder, 0);

            //プレハブを指定位置に生成
            Instantiate(EnemyPrefab, posleft, Quaternion.identity);
            Instantiate(EnemyPrefab, posright, Quaternion.identity);
            Instantiate(EnemyPrefab, postop, Quaternion.identity);
            Instantiate(EnemyPrefab, posunder, Quaternion.identity);
        }
        if(count > 1000)
        {
            count = 0;
        }
    }
}

