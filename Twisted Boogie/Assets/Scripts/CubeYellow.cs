using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeYellow : MonoBehaviour {
	//Variables
	public float playerSpeedOffsetZ;
	private bool setTurnRight = false;
	private Pivot pivotPoint;

	void Start () {
		pivotPoint = GameObject.FindObjectOfType<Pivot>();
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
		//Vector3 tobyTurn = new Vector3(510f, 1f, 100f);
		//transform.RotateAround(tobyTurn, Vector3.up, 10 * Time.deltaTime);
		float pivotX = pivotPoint.transform.position.x;
		float pivotY = pivotPoint.transform.position.y;
		float pivotZ = pivotPoint.transform.position.z;

		Vector3 tobyTurn = new Vector3(pivotX, pivotY, pivotZ);
		transform.RotateAround(tobyTurn, Vector3.up, 300 * Time.deltaTime);
		//transform.Translate(Vector3.forward * playerSpeedOffsetZ * Time.deltaTime);
	}//End
}
