using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarryMove : HarryAttack
{
    //public CharacterController2D controller;

    public GameObject camera;
    
    public Transform GroundCheckPoint;
    public float GroundCheckRadius;
    public LayerMask GroundLayer;
    private bool isTouchingGround;

    public float runSpeed = 40f;
    float horizontalMove = 0f;
    float verticalMove = 0f;
    public Joystick joystick;

    
    public Rigidbody2D rb;
    
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

        horizontalMove = joystick.Horizontal;//* runSpeed;
        verticalMove = joystick.Vertical;//* runSpeed;

        //print("x=" + horizontalMove + "  y=" + verticalMove);
        
        //rb.velocity = new Vector2( horizontalMove * 5,0);
        
        if (Input.GetKey("a") || (horizontalMove<-0.1f))
        {
            SP = GetComponent<SpriteRenderer>();
            SP.sprite = walkSprite; 
            SP.flipX = true;  

            rb.velocity = new Vector2(-5,0);
        }
        else
        {
            Stand();
        }

        if (Input.GetKey("d") || (horizontalMove>0.1f))
        {
            SP = GetComponent<SpriteRenderer>();
            SP.sprite = walkSprite; 
            SP.flipX = false;  
     
            rb.velocity = new Vector2(5,0);
        }
        else
        {
            Stand();
        }
        

        if ( (Input.GetKeyDown("w") || (verticalMove>=0.3f)) && isTouchingGround)
        {
            rb.velocity=velocity;
            print("do jump");
        }
        
        if (isTouchingGround == false)
        {
            SP = GetComponent<SpriteRenderer>();
            SP.sprite = jumpSprite; 
        }
        
        return;    
    }



}
