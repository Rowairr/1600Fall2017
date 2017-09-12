using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathOperators : MonoBehaviour {
	void Start () {
		/*Math Operators are functions you can code that work as math 
		functions */
		//For example,
		//You can add, subtract, multiply, divide, and modulize
		//Subtraction takes on this form
		int x = 4;
		int y = 5;
		print(y-x);
		//Addition takes on this form
		int a = 7;
		int b = 5;
		print(a-b);
		//Multiplication takes on this form
		print(y*b);
		//Division looks a little something like this
		print(a/b);
		/*However, division will not yield the correct decimal result.
		Instead, the answer will be 1.*/
		print(a%b);
		/*This operation will yield the remainder of the division problem,
		so the print for this would be 2 */
		//If you want to be fancy, you can even do longer equations.
		print(x+y-a);
		/*The answer to this will be 2. The order of operations still applies
		in coding. The coding program will first read items in parentheses, then
		multiplications, then division, then modulus, addition, subtraction */
		print(a/b*x);
		/*In this situation b and x would multiply together, and then a would be
		divided by that outcome. To change that, we will add parentheses*/
		print((a/b)*x);
		/*Now, a will be divided by b before that outcome is multiplied by x.
		Therefore the outcome will be 4. Because 7/5 is read as 1. However,
		I would like it to come out as being 2, so I will change it to a modulus */
		print((a%b)*x);
		/*Now we're going to get really fancy. */
		print((x*y/b)+(x*y/b));
		/*Using the order of operation the equation will compute out the
		equations inside the parentheses starting with x times y, then it
		will add the sum of the two equations together. */
	}
}
