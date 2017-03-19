//This uses the unity physics engine to move the cube


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRedMovement : MonoBehaviour {
	//Variables
	public float playerSpeedOffsetZ;
	private Rigidbody thisRigidBody;

	
	void Start () {
		thisRigidBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void FixedUpdate(){
		thisRigidBody.MovePosition(transform.position + transform.forward * playerSpeedOffsetZ * Time.deltaTime);
	}//End FixedUpdate()
}
