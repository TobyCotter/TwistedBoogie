//This uses the unity physics engine to move the cube


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRedMovement : MonoBehaviour {
	//Variables
	public float playerSpeedOffsetZ;
	public float turnSpeed;
	private Rigidbody thisRigidBody;
	private bool turnRightTrue = false;
	//private bool firstPass = true;

	
	void Start () {
		thisRigidBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1")){
			turnSpeed = Mathf.Abs(turnSpeed);
			TurnRightTrue();
		}

		//if(Input.GetButtonDown("Fire2")){
		//	turnSpeed = -turnSpeed;
		//}
	}


	void FixedUpdate(){
		//Turn Right?
		if(turnRightTrue){
			TurnRight();
		}else{
			thisRigidBody.MovePosition(transform.position + transform.forward * playerSpeedOffsetZ * Time.deltaTime);
		}
	}//End FixedUpdate()


	private void TurnRightTrue(){
		turnRightTrue = true;
		Debug.Log("About to turn!");
	}//End


	private void TurnRight(){
		//float turn = turnSpeed * Time.deltaTime;

		//Rotate around y axis
		Quaternion turnRotation = Quaternion.Euler(0f, turnSpeed * Time.deltaTime, 0f);

		//Rotate
		thisRigidBody.MoveRotation(thisRigidBody.rotation * turnRotation);
	}//End TurnMe
}//End class
