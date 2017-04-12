using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTry : MonoBehaviour {
	//Variables
	public Transform myPivot;
	public float turnSpeed;
	private bool rightTurn;
	private float reach90;



	void Start () {
		
	}
	

	void Update () {
		
	}


	void FixedUpdate(){
		if (reach90 < 90.0f && rightTurn) {
        	reach90 += (turnSpeed * Time.deltaTime);
        	Debug.Log("Turnspeed * delta: " + reach90);
            transform.RotateAround(myPivot.transform.position, Vector3.up, turnSpeed * Time.deltaTime);
        }

        if(reach90 >= 90.0f && rightTurn){
        	rightTurn = false;		//cube will begin translating fwd in the next if statement
        	reach90 = 0.0f;			//Reset for next turn
        	//transform.Rotate(0.0f, 90.0f, 0.0f);
        	transform.eulerAngles = new Vector3(0.0f, 90.0f, 0.0f);
        }

		if (!rightTurn){
            transform.Translate(Vector3.forward * 12 * Time.deltaTime);
        }
	}


	void OnTriggerEnter(Collider collider) {
    	Debug.Log("We collided with:" + collider);
    	rightTurn = true;
    }//End OnTriggerEnter
}
