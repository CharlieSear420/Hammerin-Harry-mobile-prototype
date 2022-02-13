using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarryAttack : MonoBehaviour
{
    
    public bool harryIsAttacking;
    public SpriteRenderer SP;
    public Sprite nHammerSprite;
    public Sprite standSprite;
    public Sprite enemyDead;
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
    
    public void HammerAttack()
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
            SP = GetComponent<SpriteRenderer>();
            SP.sprite = standSprite;
        }
    }

    public void SwingHammer()
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
