using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour {
	//Variables
	public Transform targetObj;
	//public float lerpSpeed;
	//public float xOffset;
	//public float yOffset;
	//public float zOffset;
	public float smoothTime = 0.3f;
	private Vector3 velocity = Vector3.zero;
	//private Vector3 camOffset;						//Distance between target object and camera
	
	void Start () {
		//camOffset = targetObj.transform.position - this.transform.position;
	}
	


	void FixedUpdate(){
		//Vector3 camOffset = new Vector3(xOffset, yOffset, zOffset);
		//Vector3 desiredPos = targetObj.transform.position + camOffset;

		//Follow Player
		//transform.position = Vector3.Lerp(transform.position, desiredPos, (lerpSpeed * Time.deltaTime));
		//transform.position = Vector3.SmoothDamp(transform.position, desiredPos, ref velocity, smoothTime);
		transform.position = Vector3.SmoothDamp(transform.position, targetObj.transform.position, ref velocity, smoothTime);

		//Rotate with player
		Vector3 relativePos = targetObj.position - transform.position;
		Quaternion rotation = Quaternion.LookRotation(relativePos);
		//rotation.y = Mathf.Clamp(rotation.y, 0.0f, 91.0f);	//Used to keep the player from starting out the turn negative
		transform.rotation = rotation;
		//Debug.Log("Rotation y: " + transform.rotation.y);
	}//End FixedUpdate

}//End PlayerCamera
