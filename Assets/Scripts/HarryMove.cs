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

        
        /*
        float xSpeed = 5.0f;
        float ySpeed = 5.0f;
        */
        horizontalMove = joystick.Horizontal;//* runSpeed;
        verticalMove = joystick.Vertical;//* runSpeed;
        

        //print("x=" + horizontalMove + "  y=" + verticalMove);
        
        //rb.velocity = new Vector2( horizontalMove * 5,0);

        
        Stand();
        
        if (Input.GetKey("a") || (horizontalMove<-0.1f))
        {
            SP = GetComponent<SpriteRenderer>();
            SP.sprite = walkSprite; 
            SP.flipX = true;  

            velocity.x=-3;
        }

        if (Input.GetKey("d") || (horizontalMove>0.1f))
        {
            SP = GetComponent<SpriteRenderer>();
            SP.sprite = walkSprite; 
            SP.flipX = false;  
     
            velocity.x = 3;
        }
        

        if ( (Input.GetKeyDown("w") || (verticalMove>=0.3f)) && isTouchingGround)
        {
            velocity.y = 6;
            //print("do jump");
        }
        
        if (isTouchingGround == false)
        {
            SP = GetComponent<SpriteRenderer>();
            SP.sprite = jumpSprite; 
        }

        Attack();
        

        rb.velocity = velocity;
        
    }

    public void Attack()
    {
        

        if (Input.GetKey("g"))
        {
            
            harryIsAttacking = true;
            SP = GetComponent<SpriteRenderer>();
            SP.sprite = nHammerSprite;
            print("mouse click");
            
        }
        else
        {
            harryIsAttacking = false;  
            
        }
    }



}
