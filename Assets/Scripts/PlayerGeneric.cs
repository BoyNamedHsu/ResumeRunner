using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGeneric : MonoBehaviour
{
    public float speed;
    public int jumpHeight;
    // Start is called before the first frame update
    public void Start()
    {
      speed = 5;
      jumpHeight = 7;
    }

    // Update is called once per frame
    public void Update()
    {
      transform.Translate(transform.right * speed * Time.deltaTime);
    }
}
