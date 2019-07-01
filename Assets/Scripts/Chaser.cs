using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaser : PlayerGeneric
{
    // Start is called before the first frame update
    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        base.Start();
    }

    // Update is called once per frame
    public void Update()
    {
        base.Update();
    }
}
