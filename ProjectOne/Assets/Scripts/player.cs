using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class player : MonoBehaviour
{
   [SerializeField]private float PlayerSpeed;
    private Rigidbody2D rb;
    public bool isJumping;
    

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
            if (Input.GetKey(KeyCode.Space) && isJumping == false) 
            { 
                rb.velocity = new Vector2(rb.velocity.x, PlayerSpeed);
            }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            isJumping = false;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            isJumping = true;
        }
    }



} 
