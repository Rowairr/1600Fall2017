using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Convention is the organization of code to make things easier to find, such as comments,
//and code blocks. These comments would be an example of Convention. 

public class Bird : Animal {
	//This code block would also be an example of convention. It starts here,
public override void Start(){
	base.Start();
	Fly();
	//And ends here, showing us one task we're asking a program to do.
}
//Syntax is the organization of our statements so that the computer can read it.
//For example, the parenthesis below allow us to add a modifier to the command void Fly
void Fly (){
	//Another example, the curly braces show the start and end of this data block.
	print(this.name + " Flies");//This semicolon shows the end of the statement.
	//The double quotation marks shows our string of text
}
}
