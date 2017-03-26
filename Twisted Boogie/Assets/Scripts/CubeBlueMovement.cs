//This moves the cube via kinematic translate movement


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBlueMovement : MonoBehaviour {
	//Variables
	public float playerSpeedOffsetZ;
	private float zSpeed;
	private float dummyVar;
	private Animator animator;


	void Start () {
		animator = GetComponent<Animator>();
	}//End Start
	

	void Update () {
		//zSpeed = (playerSpeedOffsetZ * Time.deltaTime);	//Mistake!!!  The delta time was in the update instead of the fixedUpdate
		for (int i = 0; i < 10000000; i++) {
			dummyVar = (dummyVar * 6) + 5;
		}

		if(Input.GetButtonDown("Fire2")){
			Debug.Log("Blue turn right signalled");
			animator.SetBool("RightTurn", true);
		}else{
			animator.SetBool("RightTurn", false);
		}
		
	}//End Update


	void FixedUpdate(){
		//transform.Translate(0, 0, zSpeed);
		transform.Translate(Vector3.forward * playerSpeedOffsetZ * Time.deltaTime);
	}//End FixedUpdate
}
