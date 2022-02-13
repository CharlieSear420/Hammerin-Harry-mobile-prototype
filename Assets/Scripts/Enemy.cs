using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : HarryAttack
{
    public int maxHealth = 100;

    int currentHealth;

    public Rigidbody2D rb;
    
    
    public float speed = 35f;
    
    public Transform target;
    
   
    void Start()
    {
        currentHealth = maxHealth;
        rb = GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {
        
    }

    public void TakeDamage (int TakeDamage)
    {
        currentHealth -= TakeDamage;

        //animate (?)

        if(currentHealth <=0)
        {
            Die();
        }


    }

    

    void Die()
    {
        print ("dead");
        
        //die anim (?)
        SP = GetComponent<SpriteRenderer>();
        SP.sprite = enemyDead;
        //disbale enemy
        //GameObject.Destroy(this);

        //rb = false;
        // find the code to deactivate the rigidbpdy and box collider so the skull and crossbones wont collide with player (?)
    }

    
}
