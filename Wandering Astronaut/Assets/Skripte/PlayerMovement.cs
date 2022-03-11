using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    
    public float jumpForce = 10f;
    public bool grounded = true;
    private Rigidbody2D rg;
    void Start()
    {
        rg = GetComponent < Rigidbody2D >();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (grounded==true)
        {
            rg.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
            
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.collider.tag == "Ground")
        {
            grounded = true;
        }

    }
    void OnCollisionExit2D(Collision2D col)
    {
        if (col.collider.tag == "Ground")
        {
            grounded = false; 
        }
    }
}

