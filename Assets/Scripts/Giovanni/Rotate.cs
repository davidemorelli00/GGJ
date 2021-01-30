using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    //public float torchRotation = 10f;
    
    public float horizontalSpeed = 2.0F;
    public float verticalSpeed = 2.0F;

    public float min = 150;
    public float max = 210;

    void Start()
    {
    }
    
    void Update ()
    {
        /*Plane playerplane = new Plane(Vector3.up, transform.position);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float hitdist;

        if (playerplane.Raycast(ray, out hitdist))
        {
            Vector3 targetpoint = ray.GetPoint(hitdist);
            Quaternion targetrotation = Quaternion.LookRotation(targetpoint - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetrotation, torchRotation * Time.deltaTime);
        }*/
        
        float h = horizontalSpeed * Input.GetAxis("Mouse X");
        float v = verticalSpeed * Input.GetAxis("Mouse Y");
        transform.Rotate(0, h, 0);

        h = Mathf.Clamp(h, min, max);

    }
}