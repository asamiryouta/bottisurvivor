using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousepoint : MonoBehaviour
{
<<<<<<< Updated upstream
    // Start is called before the first frame update
=======
    //�ʒu���W
    private Vector2 mousePos;
    //�X�N���[�����W���[���h���W�ɕϊ����Ĉʒu���W
    private Vector2 screenToWorldPointPosition;
>>>>>>> Stashed changes
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< Updated upstream
        
=======
        //Vector2�Ń}�E�X�ʒu���W���擾����
        mousePos = Input.mousePosition;


        this.transform.position = mousePos;



>>>>>>> Stashed changes
    }
}
