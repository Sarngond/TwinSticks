using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class CameraPan : MonoBehaviour {

	private GameObject player;
	//private Vector3 cameraOffset;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		//cameraOffset = new Vector3 (-10, 2, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void LateUpdate () {
		transform.LookAt (player.transform);
		//transform.position = player.transform.position + cameraOffset;
	}
}
