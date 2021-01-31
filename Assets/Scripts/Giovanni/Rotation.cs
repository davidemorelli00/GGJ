using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    private float rotationZ = 0f;
    private float sensitivityZ = 2f;

    void Update()
    {

        rotationZ += Input.GetAxis("Mouse X") * sensitivityZ;
        rotationZ = Mathf.Clamp (rotationZ, 45, 135);
             
        transform.localEulerAngles = new Vector3(-rotationZ, 0, 0);

    }
}
