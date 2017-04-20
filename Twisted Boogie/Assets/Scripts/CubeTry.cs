using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTry : MonoBehaviour {
	//Variables
	public Transform myPivot;
	public float turnSpeed;
	private bool rightTurn;
	private float reach90;
	private Vector3 colliderPivot;
	private float currentY_rotation;
	private float targetYAngle;


	void Start () {
		
	}
	

	void Update () {
		
	}


	void FixedUpdate(){
		//Turn right
		if (reach90 < 90.0f && rightTurn) {
        	reach90 += (turnSpeed * Time.deltaTime);			//We want to keep turning unti we reach 90 degrees
           	transform.RotateAround(colliderPivot, Vector3.up, turnSpeed * Time.deltaTime);
        }

        //After turning right, straighten
        if(reach90 >= 90.0f && rightTurn){
        	rightTurn = false;									//cube will now begin translating fwd in the next if statement
        	reach90 = 0.0f;										//Reset for next turn

        	//Straighten by setting rotation to absolute value
       		targetYAngle = currentY_rotation + 90.0f;
        	transform.eulerAngles = new Vector3(0.0f, targetYAngle, 0.0f);
        }

        //Straight velocity
		if (!rightTurn){
            transform.Translate(Vector3.forward * 12 * Time.deltaTime);
			currentY_rotation = transform.eulerAngles.y;		//Used for strightening out after a turn later on
			Debug.Log("current eulerAngle y: " + transform.eulerAngles.y);
        }
	}


	void OnTriggerEnter(Collider collider) {
    	Debug.Log("We collided with:" + collider);
    	rightTurn = true;
    	colliderPivot = collider.transform.position;
    }//End OnTriggerEnter
}