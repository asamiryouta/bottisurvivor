using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousepoint : MonoBehaviour
{
<<<<<<< Updated upstream
    // Start is called before the first frame update
=======
    //位置座標
    private Vector2 mousePos;
    //スクリーン座標ワールド座標に変換して位置座標
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
        //Vector2でマウス位置座標を取得する
        mousePos = Input.mousePosition;


        this.transform.position = mousePos;



>>>>>>> Stashed changes
    }
}
