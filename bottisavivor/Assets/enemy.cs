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
        //�v���C���[�̃I�u�W�F�N�g���擾
        g = GameObject.Find("player");


        p = new Vector2();

    }

    // Update is called once per frame
    void Update()
    {
        //�v���C���[�Ɍ������x�N�g���̍쐬
        p =g.transform.position -this.transform.position;
        //�������g���v���C���[�Ɍ����Ĉړ�
        this.transform.position += p / 50;
    }

    
    
}
