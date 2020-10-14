using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class animationScript : MonoBehaviour
{

    public Sprite spriteIdle;
    public Sprite spriteJumping;
    public Sprite spriteCrouching;
    SpriteRenderer sr;
    Rigidbody2D rb;
    
    void Update()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        float yAxis = rb.velocity.y;

        if (yAxis != 0)
        {
            sr.sprite = spriteJumping;
        }

        if (Input.GetKey("s") && yAxis == 0)
        {
            sr.sprite = spriteCrouching;           
        }

        else
        {
            sr.sprite = spriteIdle;
        }
    }
}
