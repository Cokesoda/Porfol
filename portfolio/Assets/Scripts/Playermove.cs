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
        Debug.Log(MoveVector3);

        v = Input.GetAxisRaw("Vertical");
        h = Input.GetAxisRaw("Horizontal");
        MoveVector3 = new Vector3(h,0,v);
        MoveVector3.Normalize();
    }
    private void FixedUpdate()
    {
        transform.Translate(MoveVector3 * MoveSpeed * Time.fixedDeltaTime);
    }
}
