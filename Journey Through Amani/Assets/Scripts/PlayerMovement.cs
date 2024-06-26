using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 1f;

    private void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Camera.main.orthographicSize != 5.0f)
        {
            Debug.Log("Camera size changed to: " + Camera.main.orthographicSize);
        }

        Vector2 movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        rb.velocity = movement;

        // Flip the sprite based on movement direction
        if (movement.x > 0)
        {
            gameObject.transform.localScale = new Vector2(-1, 1);
        }
        else if (movement.x < 0)
        {
            gameObject.transform.localScale = new Vector2(1, 1);

        }
    }



    private void FixedUpdate()
    {
        rb.MovePosition(rb.velocity.normalized * speed * Time.fixedDeltaTime + rb.position);
    }
}