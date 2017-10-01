using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltMove : MonoBehaviour {

public float speed;
private Rigidbody rig;
void Start ()
{
	rig = GetComponent<Rigidbody>();
}
void Update ()
{
	float hAxis = Input.GetAxis("Horizontal");
	float vAxis = Input.GetAxis("Vertical");

	Vector3 movement = new Vector3(hAxis,0,vAxis)*speed*Time.deltaTime;
	rig.MovePosition(transform.position+movement);
}

}

