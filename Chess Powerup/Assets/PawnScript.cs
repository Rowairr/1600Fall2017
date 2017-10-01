using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawnScript : MonoBehaviour {
public float speed;
public int condition = 5;
private Rigidbody rig;
public Transform attachObject;
private MeshRenderer mesh;

void Start ()
{
	rig = GetComponent<Rigidbody>();
	mesh = GetComponentInChildren<MeshRenderer>();
	mesh.enabled=false;
}
void OnTriggerEnter()
{
	//gameObject.SetActive(true);
	transform.parent=attachObject;
	GetComponent<BoxCollider>().enabled=false;
	condition += 5;
	mesh.enabled=true;
}
void Update()
{
	if (condition == 10){
	float hAxis = Input.GetAxis("Horizontal");
	float vAxis = Input.GetAxis("Vertical");

	Vector3 movement = new Vector3(hAxis,0,vAxis)*speed*Time.deltaTime;
	rig.MovePosition(transform.position+movement);
}
}
}



