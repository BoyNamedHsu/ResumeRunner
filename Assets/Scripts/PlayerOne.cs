using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOne : PlayerGeneric
{
    private Rigidbody2D rb;
    // Start is called before the first frame update
    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        base.Start();
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            rb.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
        }
        base.Update();
    }
}
