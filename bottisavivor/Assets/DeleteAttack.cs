using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteAttack : MonoBehaviour
{
    int time;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (time > 30)
        {
            Destroy(this.gameObject);
        }

        //timer
        time++;
    }
}
