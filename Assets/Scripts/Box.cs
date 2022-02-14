using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public int maxHealth = 10;

    public int currentHealth;
    private Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage ()
    {
        Die();


    }

    void Die()
    {
        print ("box broken");
        
        gameObject.SetActive(false);

    }
}
