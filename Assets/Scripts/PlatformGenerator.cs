using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : Generator
{
    
    // Randomly generate obstacles with resp. to PlatformGenerationPoint
    public GameObject platform;

    void Start() {
        //Grab the BoxCollider of the platform 
        platformWidth = platform.GetComponent<BoxCollider2D>().size.x;
    }

    // Update is called once per frame
    void Update()
    {
        // if this.position.x is less than the generation point,  move tranform position over a bit
        if( transform.position.x < generationPoint.position.x) {
            transform.position = new Vector3(transform.position.x + platformWidth, transform.position.y, transform.position.z);

            //create a copy of the platform
            Instantiate (platform, transform.position, transform.rotation);
        }
    }
}
