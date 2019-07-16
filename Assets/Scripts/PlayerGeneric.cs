using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGeneric : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;

    // Field that controls how fast you fall
    public float fallMultiplier;
    public int jumpHeight;
    public int jumpForce;
    public BoxCollider col;
    // Start is called before the first frame update
    public void Start()
    {
      speed = 5;
      jumpHeight = 7;
      jumpForce = 10;
      fallMultiplier = 2.5f;
      col = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    public void Update()
    {

      // Move right at speed
      transform.Translate(transform.right * speed * Time.deltaTime);
    }
}
