using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : Mammal {
public override void Start(){
	base.Start();
	Study();
}
void Study (){
	print(this.name + " Studies");
}
}
