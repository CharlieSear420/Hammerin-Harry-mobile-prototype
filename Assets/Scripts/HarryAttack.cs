using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarryAttack : MonoBehaviour
{
    
    public bool harryIsAttacking;
    public SpriteRenderer SP;
    public Sprite nHammerSprite;
    public Sprite standSprite;
    //SpriteRenderer spriteRenderer;
    public Sprite jumpSprite;
    //public Sprite standSprite;
    public Sprite walkSprite;
    
    
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    public void hammerAttack()
    {
        if (Input.GetKey("g"))
        {
            swingHammer();
            print("mouse click");
            harryIsAttacking = true;
        }
        else
        {
            harryIsAttacking = false;
            Stand();
        }
    }

    public void swingHammer()
    {
        SP = GetComponent<SpriteRenderer>();
        SP.sprite = nHammerSprite;
    }
    public void Stand()
    {
        SP = GetComponent<SpriteRenderer>();
        SP.sprite = standSprite;
    }
}
