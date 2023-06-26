using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sutoka : MonoBehaviour
{
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
      
        
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion lookrotation = Quaternion.LookRotation(target.transform.position, Vector2.up);


        lookrotation.x = 0;
        lookrotation.y = 0;

        transform.rotation = Quaternion.Lerp(transform.rotation, lookrotation, 0.1f);

        Vector2 p = new Vector2(0f, 0f);

        transform.Translate(p);
    }
}
