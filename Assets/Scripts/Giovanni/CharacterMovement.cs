using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float walkingSpeed = 4.0f;
    public float runningSpeed = 8.0f;
    public float rotationSpeed = 100.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Walk();
        Run();
    }
    
    void Walk()
    {
        float translation = Input.GetAxis("Vertical") * walkingSpeed * Time.deltaTime;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;

        transform.Translate (0,0,translation);
        transform.Rotate (0,rotation,0);

        /*if(translation != 0) {
            anim.SetBool("isWalking", true);
            if(Input.GetKey("s")){
                anim.SetBool("isWalkingBack", true);
            }
        } else {
            anim.SetBool("isWalking", false);
            if(!Input.GetKey("s")){
                anim.SetBool("isWalkingBack", false);
            }
        }*/
    }

    void Run()
    {
        if(Input.GetKey(KeyCode.LeftShift))
        {
            //anim.SetBool("isRunning", true);

            float translation = Input.GetAxis("Vertical") * runningSpeed * Time.deltaTime;
            float rotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;

            transform.Translate (0,0,translation);
            transform.Rotate (0,rotation,0);

        }
    }
}
