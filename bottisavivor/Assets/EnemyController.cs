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
        //�v���C���[�̃I�u�W�F�N�g���擾
        Enemy = GameObject.Find("player");


        Player = new Vector2();

    }

    // Update is called once per frame
    void Update()
    {
        //�v���C���[�Ɍ������x�N�g���̍쐬
        Player =Enemy.transform.position -this.transform.position;
        Player = Player.normalized;
        //�������g���v���C���[�Ɍ����Ĉړ�
        this.transform.position +=  Player / 200;
    }

    
    
}
