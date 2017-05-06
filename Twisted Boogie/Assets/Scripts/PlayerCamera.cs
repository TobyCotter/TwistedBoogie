using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour {
	//Variables
	public Transform targetObj;

	private Vector3 velocity = Vector3.zero;

	[Tooltip("Higher number makes camera's speed lag more")] 
	[SerializeField] private float smoothTime = 0.3f;				//Camera speed lag
	[Range(0.0f, 1.0f)]
	[Tooltip("Lower number makes camera's rotation lag more")]
	[SerializeField] private float rotateSpeed = .125f;				//Camera rotation lag


	
	void Start () {

	}

	void FixedUpdate(){
		//Follow Player
		transform.position = Vector3.SmoothDamp(transform.position, targetObj.transform.position, ref velocity, smoothTime);
		//Rotate with player
		transform.rotation = Quaternion.Slerp(this.transform.rotation, targetObj.transform.rotation, rotateSpeed);
	}//End FixedUpdate




	/*
	//The following was done with LookRotation

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
	*/

}//End PlayerCamera
