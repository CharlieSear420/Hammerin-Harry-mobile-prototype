using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarryMove : HarryAttack
{
    
    public GameObject camera;
    
    public Transform GroundCheckPoint;
    public float GroundCheckRadius;
    public LayerMask GroundLayer;
    private bool isTouchingGround;
    
    Rigidbody2D rb;
    
    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
    }
   
    void Update()
    {
        isTouchingGround = Physics2D.OverlapCircle(GroundCheckPoint.position, GroundCheckRadius, GroundLayer);
        Vector2 velocity=rb.velocity;

        velocity.x=0;
        velocity.y=5;
        
        float xSpeed = 5.0f;
        float ySpeed = 5.0f;
        
        if (Input.GetKey("a"))
        {
            SP = GetComponent<SpriteRenderer>();
            SP.sprite = walkSprite;   

            rb.velocity = new Vector2(-5,0);
        }
        else
        {
            Stand();
        }

        if (Input.GetKey("d"))
        {
            SP = GetComponent<SpriteRenderer>();
            SP.sprite = walkSprite; 
     
            rb.velocity = new Vector2(5,0);
        }
        else
        {
            Stand();
        }

        if (Input.GetKey("w") && isTouchingGround)
        {
            rb.velocity=velocity;
        }
        
        if (isTouchingGround == false)
        {
            SP = GetComponent<SpriteRenderer>();
            SP.sprite = jumpSprite; 
        }
        
        return;    
    }

}
