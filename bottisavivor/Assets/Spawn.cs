using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    //�v���n�u�i�[�p
    public GameObject EnemyPrefab;
    //�@�����l�̓G���o�����������i�����j
    private int numberOfEnemyPrefab;

    //�@���̏ꏊ����o������G�̐�
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
            //�v���n�u���w��ʒu�ɐ���
            Instantiate(EnemyPrefab, pos , Quaternion.identity);
            //�@���̏ꏊ����o������ő吔�𒴂��Ă��牽�����Ȃ�
            if (numberOfEnemyPrefab >= maxNumOfEnemyEnemyPrefab)
            {
                return;
            }
        }

        

    }
}
