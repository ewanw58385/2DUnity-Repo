using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMove : MonoBehaviour
{

    float timer;
    float xSpeed;
    float xDirection = 2;

    void Start()
    {
        timer = 0;
        xSpeed = 0f;
    }

    void Update()
    {
        timer++;
        Debug.Log(timer);
     
        if (timer > 75)
        {
            timer = 0f;
            xDirection = xDirection - xDirection;            
            xSpeed = 0.5f;
            transform.rotation = Quaternion.Euler(0, 180f, 0);
            transform.position = new Vector3(xDirection, 3, 0);
        }

    }
}

