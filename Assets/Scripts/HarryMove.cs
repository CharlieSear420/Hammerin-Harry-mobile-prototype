using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarryMove : HarryAttack
{
    //public CharacterController2D controller;

    public GameObject camera;

    public int countDown;

    public int i;
    
    //ground check
    public Transform GroundCheckPoint;
    public float GroundCheckRadius;
    public LayerMask GroundLayer;
    private bool isTouchingGround;
    
    //joystick movement
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    float verticalMove = 0f;
    public Joystick joystick;

    //attacking
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
    
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
            velocity.y = 5;
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
            //animate
            SP = GetComponent<SpriteRenderer>();
            SP.sprite = nHammerSprite;
            
            //detect enemies within range
            Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

            //damage them
            foreach(Collider2D enemy in hitEnemies)
            {
                print ("We hit " + enemy.name);
            }
        
        }
        else
        {
            harryIsAttacking = false;  
            
        }
    }

    public void OnDrawGizmosSelected()
    {
        if (attackPoint == null!)
        {
            return;
        }
            
        
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }



}
