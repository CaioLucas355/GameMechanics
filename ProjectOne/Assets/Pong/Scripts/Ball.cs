using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rb;
    public float starting_speed;

    // Start is called before the first frame update
    void Start()
    {
        bool isRight = UnityEngine.Random.value > 0.5;
        float xVelocity = -1f;

        if (isRight)
        {
            xVelocity = 1f;
        }

        float yVelocity = UnityEngine.Random.Range(-1, 1);

        rb.velocity = new Vector2(xVelocity * starting_speed, yVelocity* starting_speed);
    
    
    
    }

    // Update is called once per frame
    void Update()
    {
    }
}
