﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour {
public CharacterController charactercontroller;
public static bool gameOver = false;
public float gravity = 9.81f;
public float speed = 12;
public Vector3 moveVector3;
public float jumpForce = 200;
	
	void FixedUpdate () {
		moveVector3.y -= gravity * Time.deltaTime;
		if(charactercontroller.isGrounded && !gameOver){
			if(Input.GetKeyDown(KeyCode.Space)){
			moveVector3.y = jumpForce * Time.deltaTime;
			}
			moveVector3.z = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
		}
		charactercontroller.Move(moveVector3);
	}
}