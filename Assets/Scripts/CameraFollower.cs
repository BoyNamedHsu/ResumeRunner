using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public Transform player;
    // Start is called before the first frame update
    void LateUpdate()
    {
        transform.position = new Vector3(player.position.x, 0, -10);
    }
}
