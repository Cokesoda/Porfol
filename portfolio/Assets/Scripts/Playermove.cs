using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermove : MonoBehaviour
{
    public float MoveSpeed;
    
    float v;
    float h;

    Vector3 MoveVector3;

    private void Update()
    {
        Debug.Log(v + h);

        v = Input.GetAxis("Vertical");
        h = Input.GetAxis("Horizontal");
        MoveVector3 = new Vector3(h,0,v);
        transform.Translate(MoveVector3 * MoveSpeed * Time.fixedDeltaTime);
    }

}
