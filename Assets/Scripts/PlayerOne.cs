using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOne : PlayerGeneric
{

    bool isGrounded;

    // Sets how much higher you jump by holding down the jump button
    public float lowJumpMultiplier;
    public BoxCollider ground;
    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        lowJumpMultiplier = 2f;
        base.Start();
    }

    // Update is called once per frame
    public void Update()
    {
        base.Update();

        // If falling, then multiply gravity to simulate a faster fall
        // Else if moving up and the jump button is still held, increase jump by a bit
        if (rb.velocity.y < 0) {
                rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        } else if (rb.velocity.y > 0 && !Input.GetKeyDown(KeyCode.Space)) {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
        }

        if (isGrounded && Input.GetKeyDown(KeyCode.Space)) {
            isGrounded = false;
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground") {
            isGrounded = true;
        }
    }
}
