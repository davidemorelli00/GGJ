using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    void Update()
    {
        lockedRotation();
    }

    void lockedRotation()
    {
        transform.position += new Vector3(Input.GetAxis("Mouse X"), 0, 0);
        
        var pos = transform.position;
        pos.x =  Mathf.Clamp(transform.position.x, -5.0f, 5.0f);
        transform.position = pos;
    }
}
