using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    public Transform target; // camera will follow the player (player object)
    public float smoothing = 5f; // camera should lag behind a bit
    Vector3 offset; // private variable - distance between camera,player

	// Use this for initialization
	void Start () {
        offset = transform.position - target.position;	
	}

	void FixedUpdate () {
        // player is also moving in FixedUpdate, camera follows him
        Vector3 targetCamPos = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime); // move (smoothly)
	}
}
