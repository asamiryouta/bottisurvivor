using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idou : MonoBehaviour
{

    public float speed = 20; //  �X�s�[�h : inspector�Ŏw��

    float vx = 0;       //float�^x���W
    float vy = 0;       //float�^y���W
    bool leftFlag = false;
    //�L�[�������ƁA�X�v���C�g���ړ�����
    void Update()
    {   //�����ƍs��
        vx = 0; //float�^x���W
        vy = 0; //float�^y���W
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
        //�J�[�\���ʒu���擾
       
    }

    void FixedUpdate()
    {
        //�ړ�����

        this.transform.Translate(vx / 50,vy / 50, 0);

        //���E�̌�����ς���
        this.GetComponent<SpriteRenderer>().flipX = leftFlag;
    }
}
