using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private GameObject playerObject;    //�v���C���[�I�u�W�F�N�g
    private Vector3 PlayerPosition;     //�v���C���[�̈ʒu���
    private Vector3 EnemyPosition;      //�G�̈ʒu���

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
