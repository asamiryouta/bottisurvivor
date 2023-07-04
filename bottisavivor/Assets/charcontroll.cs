using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charcontroll : MonoBehaviour
{

    public float playerspeed;//�v���C���[�̈ړ����x
    public float speedx;//�c�����ւ̈ړ�
    public float speedy;//�������ւ̈ړ�
    bool isleftFlag = false;//���E���]�����邽�߂̕ϐ�

    //�L�[�������ƁA�v���C���[���ړ�����
    void Update()
    {
        //��ɍs������
        speedx = 0;//�������͂��Ă��Ȃ��ꍇ�͎~�܂�
        speedy = 0;//�������͂��Ă��Ȃ��ꍇ�͎~�܂�



        if (Input.GetKey("d"))//d�L�[����͂����ꍇ
        {
            speedx = playerspeed;//�E�����ɐi��
            isleftFlag = false;//�������E�ɂ���
        }
        if (Input.GetKey("a"))//a�L�[����͂����ꍇ
        {
            speedx = -playerspeed;//�������ɐi��
            isleftFlag = true;//�������ɂ���
        }
        if (Input.GetKey("w"))//w�L�[����͂����ꍇ
        {
            speedy = playerspeed;//������ɐi��

        }
        if (Input.GetKey("s"))//s�L�[����͂����ꍇ
        {
            speedy = -playerspeed;//�������ɐi��

        }
        if (Input.GetKey("right"))//���L�[����͂����ꍇ
        {
            speedx = playerspeed;//�E�����ɐi��
            isleftFlag = false;//�������E�ɂ���
        }
        if (Input.GetKey("left"))//���L�[����͂����ꍇ
        {
            speedx = -playerspeed;//�������ɐi��
            isleftFlag = true;//���������ɂ���
        }
        if (Input.GetKey("up"))//���L�[����͂����ꍇ
        {
            speedy = playerspeed;//������ɐi��
        }
        if (Input.GetKey("down"))//���L�[����͂����ꍇ
        {
            speedy = -playerspeed;//�������ɐi��
        }
    }

    void FixedUpdate()
    {
        //�ړ�����

        this.transform.Translate(speedx / 50, speedy / 50, 0);

        //���E�̌�����ς���
        this.GetComponent<SpriteRenderer>().flipX = isleftFlag;
    }
}