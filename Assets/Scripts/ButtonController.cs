using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : HarryAttack
{
    public int n;

    public Transform attackPoint;
    public Transform attackPoint2;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
    public int attackDamage = 110;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonPress()
    {
        n++;
        print("Button was pressed " + n + " times");
        //animate
        

        //SwingHammer();
            
        //detect enemies within range
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers); 
            


        Collider2D[] hitBadEnemies = Physics2D.OverlapCircleAll(attackPoint2.position, attackRange, enemyLayers);

        //damage them
        foreach(Collider2D enemy in hitEnemies)
        {
            print ("We hit " + enemy.name);

            enemy.GetComponent<Enemy>().TakeDamage(attackDamage);
            //enemy.GetComponent<BossEnemy>().TakeDamage(attackDamage);
        }

        foreach(Collider2D enemy in hitBadEnemies)
        {
            print ("We hit " + enemy.name);

            enemy.GetComponent<Enemy>().TakeDamage(attackDamage);
            //enemy.GetComponent<BossEnemy>().TakeDamage(attackDamage);
        }
    }

    public void AnimateAttack()
    {
        SP = GetComponent<SpriteRenderer>();
        SP.sprite = nHammerSprite;
    }
}
