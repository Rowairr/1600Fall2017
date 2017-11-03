using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicalOperators : MonoBehaviour {
/*Logical operators are another thing we use to check for truth.
First is the && operator. */

public int AndExample = 20;
public int AndReq = 5;
public int AndReq2 = 7;
public int IfOpt1 = 36;
public int IfOpt2 = 42;

void Update(){
if(AndExample>10&&AndReq>3){
	print("That's And operators for you");
	
}else{
		print("Error");
}
if(AndExample>10&&AndReq>3&&AndReq2>5){
	print("There's multiple Ands here");
}
/*You can use an infinite number of And statements in a function */

if(IfOpt1 > 25 || IfOpt2 > 50){
	print("That's If operators for you");
}
/*You can use an infinite amount of Or logics in a function */
if(IfOpt1 > 38 || IfOpt2 > 50 || AndReq == 5){
	print("There's multiple ifs here");
}
if(!(IfOpt1>=50)){
	print("That's Not logics for you");
}
if(!(IfOpt1<=35 || IfOpt2<=41)){
	print("There's multiple falses here, seperated by an or.");
}
if(IfOpt1 == 36 && IfOpt2 == 42){
	print("Perfect And");
}
if(!(AndExample == 5)){
	print("That's False");
if(!(AndExample == 6)){
	print("That's Also False");
}
if(!(AndExample == 3)){
	print("You're still not getting it are you?");
}
}
}
}
