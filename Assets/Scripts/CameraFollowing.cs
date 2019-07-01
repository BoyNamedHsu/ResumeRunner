using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowing : MonoBehaviour {

	public GameObject target;       //Public variable to store a reference to the player game object
  private Vector3 offset;         //Private variable to store the offset distance between the player and camera
	private float initialY; // the initial Y coordinate of player. if player moves, fucks it up

	// Use this for initialization
	void Start () {
		offset = transform.position - target.transform.position;
		initialY = target.transform.position.y;
	}

	// Update is called once per frame
	void FixedUpdate () {
		Vector3 position = transform.position;
		position.x = target.transform.position.x + 3.5f;
		position.y = initialY;
		transform.position = position;
		//print(transform.position);
	}
	void LateUpdate () {

	}

	public void revertCameraSize() {
		GetComponent<Camera>().orthographicSize = 8.5f;
	}
}
