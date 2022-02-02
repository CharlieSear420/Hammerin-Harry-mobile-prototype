using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarryMove : HarryAttack
{
    
    public GameObject camera;
    
    SpriteRenderer spriteRenderer;
    public Sprite jumpSprite;
    public Sprite standSprite;
    public Sprite walkSprite;
    public Transform GroundCheckPoint;
    public float GroundCheckRadius;
    public LayerMask GroundLayer;
    private bool isTouchingGround;
    

    public int lives = 1;

    
    
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
            spriteRenderer = GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = walkSprite;   
              

            rb.velocity = new Vector2(-5,0);
        }
        else
        {
            Stand();
        }



        if (Input.GetKey("d"))
        {
            
            spriteRenderer = GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = walkSprite; 
     
            
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
            spriteRenderer = GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = jumpSprite; 
        }
        
        /*
        if (isTouchingGround)
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = standSprite; 
        }
        */
        
        return;
        
        
        

        if (Input.GetKey("x"))
        {

            lives = 0;

        }

         
    }

    /*
    public void RotateRight()
    {
        transform.Rotate (Vector3.forward);
    }
    public void RotateLeft()
    {
        transform.Rotate (Vector3.back);
    }
    */
}
