using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTry : MonoBehaviour {
	//Variables
	public Transform myPivot;
	[SerializeField] private float turnSpeed = 10.0f;
	[SerializeField] private float playerZSpeed = 0.5f;
	private bool rightTurn;									//= True when player has pressed the right button while in right lane
	private float reach90 = 0.0f;
	private Vector3 colliderPivot;							//Vector coordinates of the turn sphere
	private float currentYRotation;						//Used to straighten out car after a turn
	private float targetYAngle;								//= currentYRotation + 90.0f


	void Start () {
		
	}
	

	void Update () {
		
	}


	void FixedUpdate(){
		//Turn right
		if (reach90 < 90.0f && rightTurn) {						//rightTurn is set in the OnTriggerEnter
        	reach90 += (turnSpeed * .02f);						//We want to keep turning unti we reach 90 degrees
			if(reach90 > 90.0f){								//Rotate around or straighten?
       			targetYAngle = currentYRotation + 90.0f;		//currentY_rotation was set below before entering the turn
        		transform.eulerAngles = new Vector3(0.0f, targetYAngle, 0.0f);	
        		rightTurn = false;
        		reach90 = 0.0f;
           	}else{
				transform.RotateAround(colliderPivot, Vector3.up, turnSpeed * .02f);
           	}
        }

        //Z velocity only
		if (!rightTurn){
            transform.Translate(Vector3.forward * playerZSpeed * .02f);
			currentYRotation = transform.eulerAngles.y;		//Used for strightening out once we reach 90 degrees
        }
	}//End FixedUpdate


	void OnTriggerEnter(Collider collider) {
    	rightTurn = true;
    	colliderPivot = collider.transform.position;
    }//End OnTriggerEnter
}//End CubeTry