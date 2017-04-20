using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour {
	//Variables
	public Transform targetObj;
	public float lerpSpeed;
	public float xOffset;
	public float yOffset;
	public float zOffset;
	//SmoothDamp variables
	public float smoothTime = 0.3f;
	private Vector3 velocity = Vector3.zero;
	
	void Start () {
		
	}
	


	void FixedUpdate(){
		Vector3 camOffset = new Vector3(xOffset, yOffset, zOffset);
		Vector3 desiredPos = targetObj.transform.position + camOffset;

		//Follow Player
		//transform.position = Vector3.Lerp(transform.position, desiredPos, (lerpSpeed * Time.deltaTime));
		transform.position = Vector3.SmoothDamp(transform.position, desiredPos, ref velocity, smoothTime);

		//Rotate with player
		Vector3 relativePos = targetObj.position - transform.position;
		Quaternion rotation = Quaternion.LookRotation(relativePos);
		transform.rotation = rotation;
	}

	private void LerpCamera(){
		
	}
}
