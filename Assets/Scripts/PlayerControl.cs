using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody2D rigidBody2D;

    public KeyCode upButton = KeyCode.W;

    public KeyCode downButton = KeyCode.S;

    public KeyCode kiriButton = KeyCode.A;

    public KeyCode kananButton = KeyCode.D;

    public float speed = 10.0f;   

    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 velocity = rigidBody2D.velocity;

        if (Input.GetKey(upButton))
        {
            velocity.y = speed;
        }

        else if (Input.GetKey(downButton))
        {
            velocity.y = -speed;
        }

        else if (Input.GetKey(kiriButton))
        {
            velocity.x = -speed;
        }

        else if (Input.GetKey(kananButton))
        {
            velocity.x = speed;
        }

        else
        {
            velocity.y = 0.0f;
            velocity.x = 0.0f;
        }
        rigidBody2D.velocity = velocity;    
    }
}