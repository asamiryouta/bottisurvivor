using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
        this.Player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = this.Player.transform.position;
        transform.position = new Vector3(
            playerPos.x,playerPos.y,transform.position.z);
        Debug.Log(playerPos.x);
         
    }
}
