//This moves the cube via kinematic translate movement


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBlueMovement : MonoBehaviour {
	//Variables
	public float playerSpeedOffsetZ;
	private float zSpeed;
	private float dummyVar;
    private bool rightTurn;
    private Vector3 pivotPoint;
    


	void Start () {
        
	}//End Start
	

	void Update () {
		
	}//End Update


	void FixedUpdate(){
        float turnAngle;

        if (!rightTurn)
        {
            transform.Translate(Vector3.forward * playerSpeedOffsetZ * Time.deltaTime);
        }
        else
        {
            turnAngle = 300 * Time.deltaTime;
            // transform.RotateAround(pivotPoint, Vector3.up, turnAngle);
            
            transform.Rotate(Vector3.up, 10000, Space.World);
        }
	}//End FixedUpdate


    void OnTriggerEnter(Collider collider) {
        Debug.Log("We collided with:" + collider);

        pivotPoint = collider.transform.position;
        rightTurn = true;
    }//End OnTriggerEnter
}
