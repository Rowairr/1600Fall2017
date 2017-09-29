using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitch : MonoBehaviour {

	public string[] weapons;

	public void MyWeaponSwitch (int I){
		switch(weapons[I])
		{
			case "Missile":
				print("Missile");
				break;

			case "Plasma":
				print("Plasma");
				break;
			
			default:
				print("You have no other weapons.");
				break;
		}
	}
}
/*In order to save space and time, and so as to not destroy this code I'm
just going to do this assignment in comments. (Array Assignment)*/

/*Arrays are a means for creating a list of objects that something can
draw on to make it easier in coding and execution. */

/*Above the array would be public string[]. Arrays are indicated by the
standard brackets. */

/*Another example of an array would be as follows

	public int[] MyNumbers; */
/*On its own this does nothing but states an array, and states that things
can be put into it. The switch statement above is what puts the weapons,
and the outputs into the weapons array. */
/*Now, let's make it do something.

	public int[] MyNumbers;
	public void MyNumbersInput (int I){
		switch(MyNumbers[I])
		{
			case 1:
			print("1")
			break;

			case 2:
			print("2")

			case 3:
			print("3")
		}
	} */
/*Because my array is in the int form, it will only except integer inputs.
If it were a string it would accept string inputs, like the weapon switch array
above. */