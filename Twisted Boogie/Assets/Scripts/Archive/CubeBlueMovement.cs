//This moves the cube via kinematic translate movement


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBlueMovement : MonoBehaviour {
	//Variables
	public float playerSpeedOffsetZ;
	public Transform myPivot;
	private float zSpeed;
	private float dummyVar;
    //private bool rightTurn = true;
    private Vector3 pivotPoint;
    


	void Start () {
        
	}//End Start
	

	void Update () {
		
	}//End Update


	void FixedUpdate(){
        //float turnAngle;

        //if (!rightTurn)
        //{
        //    transform.Translate(Vector3.forward * playerSpeedOffsetZ * Time.deltaTime);
        //}
        //else
        //{
        //    turnAngle = 300 * Time.deltaTime;
            //transform.RotateAround(pivotPoint, Vector3.up, 1);
            transform.RotateAround(myPivot.transform.position, Vector3.up, 1);
            //transform.Rotate(Vector3.up, 10000, Space.World);
        //}
	}//End FixedUpdate


    //void OnTriggerEnter(Collider collider) {
    //    Debug.Log("We collided with:" + collider);

    //    pivotPoint = collider.transform.position;
    //    rightTurn = true;
    //}//End OnTriggerEnter
}
