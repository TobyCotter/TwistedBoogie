using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeYellow : MonoBehaviour {
	//Variables
	private bool setTurnRight = false;
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire3")){
			SetTurnRightTrue();

		}
	}


	void FixedUpdate(){
		if(setTurnRight)
			TurnRight();
	}//End


	private void SetTurnRightTrue(){
		setTurnRight = true;
	}//End


	private void TurnRight(){
		Vector3 tobyTurn = new Vector3(510f, 1f, 100f);
		transform.RotateAround(tobyTurn, Vector3.up, 10 * Time.deltaTime);
	}//End
}
