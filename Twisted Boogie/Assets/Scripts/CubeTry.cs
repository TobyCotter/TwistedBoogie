using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTry : MonoBehaviour {
	//Variables
	public Transform myPivot;
	public float turnSpeed;
	[SerializeField] private float playerZSpeed = 0.5f;
	private bool rightTurn;
	private float reach90 = 0.0f;
	private Vector3 colliderPivot;
	private float currentY_rotation;
	private float targetYAngle;


	void Start () {
		
	}
	

	void Update () {
		
	}


	void FixedUpdate(){
		//Turn right
		Debug.Log("Reach 90: " + reach90);

		if (reach90 < 90.0f && rightTurn) {						//rightTurn is set in the OnTriggerEnter
        	reach90 += (turnSpeed * .02f);						//We want to keep turning unti we reach 90 degrees
        	//reach90 = Mathf.Clamp(reach90, 0.0f, 90.0f);		//Clamp so that we don't finish rotating at a non right angle
           	transform.RotateAround(colliderPivot, Vector3.up, turnSpeed * .02f);
           	if(reach90 > 90.0f){
           		Debug.LogWarning("We are larger than 90!");
				//Straighten by setting rotation to absolute value
       			targetYAngle = currentY_rotation + 90.0f;
        		transform.eulerAngles = new Vector3(0.0f, targetYAngle, 0.0f);
           	}
        }

        //After turning right, straighten
        if(reach90 >= 90.0f && rightTurn){
        	rightTurn = false;									//cube will now begin translating fwd in the next if statement
        	reach90 = 0.0f;										//Reset for next turn

        	//Straighten by setting rotation to absolute value
       		//targetYAngle = currentY_rotation + 90.0f;
        	//transform.eulerAngles = new Vector3(0.0f, targetYAngle, 0.0f);
        }

        //Straight velocity
		if (!rightTurn){
            transform.Translate(Vector3.forward * playerZSpeed * .02f);
			currentY_rotation = transform.eulerAngles.y;		//Used for strightening out after a turn later on
        }
	}//End FixedUpdate


	void OnTriggerEnter(Collider collider) {
    	rightTurn = true;
    	colliderPivot = collider.transform.position;
    }//End OnTriggerEnter
}//End CubeTry