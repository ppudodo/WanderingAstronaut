using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    
    public float jumpForce = 10f;
    public bool grounded = false;
    private Rigidbody2D rg;
    void Start()
    {
        rg = GetComponent < Rigidbody2D >();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        
            rg.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        
    }
    void OnCollisionExit2D(Collision2D col)
    {
        if (col.collider.tag == "Ground")
        {
            grounded = true; 
        }
    }
}
