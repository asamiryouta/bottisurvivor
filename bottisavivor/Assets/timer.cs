using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    //�ϐ����J�E���g�_�E���ɂȂ��Ă邯�ǋC�ɂ��Ȃ���
    //CountUpTime -> CountDownTime
    //TextCountUp -> TextCountDown
    public static float CountDownTime;�@�@//�J�E���g�_�E���^�C��
    public Text TextCountDown;  //�\���p�e�L�X�gUI

    // Start is called before the first frame update
    void Start()
    {
       CountDownTime = 0.0F;   //�J�E���g�_�E���J�n�b�����Z�b�g
    }

    // Update is called once per frame
    void Update()
    {
        //�J�E���g�A�b�v�^�C���𐮌`���ĕ\��
        TextCountDown.text = string.Format("��������  : {0.00}", CountDownTime);
        //�o�ߎ����𑝂₵�Ă���
        CountDownTime += Time.deltaTime;
        
    }
}
