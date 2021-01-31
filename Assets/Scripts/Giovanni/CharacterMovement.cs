using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    //public Transform target;
    //public Vector3 offset;

    //Transform LeftLowerArm;

    static Animator anim;
    public float walkingSpeed = 4.0f;
    public float runningSpeed = 8.0f;
    public float rotationSpeed = 100.0f;

    private Rigidbody rb;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        //LeftLowerArm = anim.GetBoneTransform(HumanBodyBones.LeftLowerArm);

    }

    void Update()
    {
        Walk();
        Run();
    }

    /*void LateUpdate()
    {
        LeftLowerArm.LookAt(target.position);
        LeftLowerArm.rotation = LeftLowerArm.rotation * Quaternion.Euler(offset);
    }*/

    void Walk()
    {
        float translation = Input.GetAxis("Vertical") * walkingSpeed * Time.deltaTime;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;

        transform.Translate (0,0,translation);
        transform.Rotate (0,rotation,0);
        
        if(translation != 0) {
            anim.SetBool("isWalking", true);

        } else {
            anim.SetBool("isWalking", false);

        }
    }

    void Run()
    {
        if((Input.GetKey(KeyCode.LeftShift) && anim.GetBool("isWalking")) == true)
        {
            anim.SetBool("isRunning", true);

            float translation = Input.GetAxis("Vertical") * runningSpeed * Time.deltaTime;
            float rotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;

            transform.Translate (0,0,translation);
            transform.Rotate (0,rotation,0);

        } else if(!Input.GetKey(KeyCode.LeftShift)){
            anim.SetBool("isRunning", false);
        }
    }
    
}
