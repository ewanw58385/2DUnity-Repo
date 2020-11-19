using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public Animator anim;

    void start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        
        float xSpeed=0;
        float ySpeed=0;

        if (Input.GetKey("a"))
        {
            // registers a key held down and returns true
            xSpeed = -3.5f;  
            transform.rotation = Quaternion.Euler(0, 180f, 0); //ref. unity forums   
             anim.SetFloat("speed", xSpeed); /*makes speed parameter the value of xspeed, 
             a forced positive number so animation should play.*/
          
        }

        if (Input.GetKey("d"))
        {
            // registers a key held down and returns true
            xSpeed = 3.5f;
            transform.rotation = Quaternion.Euler(0, 0, 0); //ref. unity forums
             anim.SetFloat("speed", xSpeed);
        } 

        if (xSpeed == 0); //if player isn't moving, parameter bool 'idle' is true so idle anim should play.
        {
         anim.SetBool("idle", true);
        }

        transform.position += new Vector3(xSpeed * Time.deltaTime, ySpeed * Time.deltaTime, 0);


        if (Input.GetKeyDown(KeyCode.Space) && GetComponent<Rigidbody2D>().velocity.y == 0)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3 (0, 5, 0);
        }   

         if (Input.GetKeyDown("w") && GetComponent<Rigidbody2D>().velocity.y == 0)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3 (0, 5, 0);
        }   
        //ref. (for preventing infinite jumping) - youtube: Design and Deploys
    }
}
