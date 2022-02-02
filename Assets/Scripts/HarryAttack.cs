using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarryAttack : MonoBehaviour
{
    
    public bool harryIsAttacking;
    SpriteRenderer SP;
    public Sprite nHammerSprite;
    public Sprite standSprite;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
