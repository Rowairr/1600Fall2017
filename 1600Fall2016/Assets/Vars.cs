using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Variables are places for storing data,
 so called because the info in them can change when a project is running.*/
public class Vars : MonoBehaviour {

	public float health = 100;
/*This would be considered a variable as our health can change 
based on the other code blocks in the program adding or subtracting from it.*/
	void Start () {
		health = 200;
	}
//As you can see the above value was changed by this variable function
	void OnTriggerEnter()
	{
		health += 20;
	}
//The variable void keeps our functions from sending back any values back to us
//Variables can be named for convenience and are usually preceeded by a data type.
/*For example, int YourAge, int is the data type signifying we need a number input
while YourAge is the variable that identifies this specific data statement*/
	void Update () {
		health = 200;
	// 	if (health > 0)
	// {
	// 	health -= 0.1f;
	// 					}else{
	// 						print("You Died");
	// 					}
	// }
}
}
