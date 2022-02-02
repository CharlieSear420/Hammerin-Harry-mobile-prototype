using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarryMove : MonoBehaviour
{
    public float speed = 1.0f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        MovePlayer();




    }

    public float GetX()
    {
        return Input.GetAxis("Horizontal");
    }
 
    public float GetY()
    {
        return Input.GetAxis("Vertical");
    }

    public void MovePlayer()
    {
       
       
        var move = new Vector3(GetX(), GetY(), 0);
        transform.position += move * speed * Time.deltaTime;
 
    }
}
