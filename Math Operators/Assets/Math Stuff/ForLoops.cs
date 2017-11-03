using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ForLoops : MonoBehaviour {
public int r = 10;
void Update(){
	for(int x = 10; x < 15; x += 1){
		print(x);
	}
	for(; r>=0; r-=1){
		print(r);
	}
	for(int l = 50; l == 50; l -= 50){
		print(l);
	}
	for(int m = 25; m <= 25; m *= 2){
		print(m);
	}
	for(int j = 6; j == 6; j += 1){
		print(j);
	}
	for(int k = 27; k >= 27; k+= -2){
		print(k);
	}
	for(int n = 2; n <= 5; n += 1){
		print(n);
	}
	for(int o = 500; o >= 500; o /= 7){
		print(o);
	}
	for(int p = 725; p >= 724; p -= 1){
		print(p);
	}
	for(int q = 52517; q >= 1; q /= 52517){
		print(q);
	}
}
}
