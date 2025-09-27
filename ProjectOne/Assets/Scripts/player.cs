using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
   [SerializeField]private float PlayerSpeed;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float horizontalInput = (Input.GetAxisRaw("Horizontal"));
        rb.velocity = new Vector2(horizontalInput * PlayerSpeed, rb.velocity.y);

        //Fliping player when it moves left-right
        if (horizontalInput > 0.01f)
        {
          
            transform.localScale = Vector3.one;
        }
        else if (horizontalInput < -0.01f)
        {
           
           transform.localScale = new Vector3(-1, 1, 1);
        }

   
        // player walking
        if (Input.GetKey(KeyCode.Space))
            rb.velocity = new Vector2(rb.velocity.x, PlayerSpeed);
        
    }
}
