using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 5f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    private void Update()
    {
 
        rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.velocity.normalized * speed * Time.deltaTime + rb.position);
    }
}