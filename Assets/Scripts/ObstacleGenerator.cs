using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : Generator
{
    //public const int NUM_SIMULTANEOUS_OBSTACLES = 2;

    // Randomly generates obstacles with resp. to PlatformGenerationPoint
    public GameObject obstacle; 

    public int maxSimulObstacles;

    // Start is called before the first frame update
    void Start() {
        //Grab the BoxCollider of the platform 
        platformWidth = obstacle.GetComponent<BoxCollider2D>().size.x;
    }

    // Update is called once per frame
    void Update()
    {
        //generate a random distance between obstacles. Add 1 to simultaneous obstacles to create
        //small space between the consecutive obstacle chunks.
        float distanceBetween = Random.Range(platformWidth * (maxSimulObstacles + 1), 
                                    platformWidth * (maxSimulObstacles + 10));

        //Generate a random amount of simultaneous obstacles
        int simObstacles = Random.Range(1, maxSimulObstacles);
        // if this.position.x is less than the generation point,  move tranform position over a bit
        if( transform.position.x < generationPoint.position.x) {
            transform.position = new Vector3(transform.position.x + platformWidth + distanceBetween, transform.position.y, transform.position.z);

            for (int i = 0; i < simObstacles; i++) 
            {
                Vector3 width = new Vector3(transform.position.x + i * platformWidth, transform.position.y, transform.position.z);
                //create a copy of the platform
                Instantiate (obstacle, width, transform.rotation);
            }
        }
    }
}
