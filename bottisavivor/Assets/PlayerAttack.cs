using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public int span = 0;
    public GameObject AttackEffect;
    GameObject go;
    Vector3 posi;
    int time;

    void FixedUpdate()
    {
        posi = this.transform.position;

        if (span > 60)
        {
            go = Instantiate(AttackEffect) as GameObject;
            go.transform.position = new Vector3(posi.x, posi.y + 5f, 0);
            span = 0;
        }


        span++;
    }
}
