using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mammal : Animal {
public override void Start(){
	base.Start();
	Shivers();
}
void Shivers (){
	print(this.name + " Shivers");
}
}
