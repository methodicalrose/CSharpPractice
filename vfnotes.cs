// A Script is a component you can make yourself that influences the behavior of game objects
using UnityEngine;
using System.Collections;

public class VariablesAndFunctions: MonoBehavior
{
   // This is a variable (box containing information); different boxes for different types of information
  int myInt= 5; // declares variable type (integer), names variable(myInt), gives value(5)

  // This is a function, or "method" (takes variable boxes, gives boxes back [return])
  void Start() { // void - does not return any boxes; Start - when the object a script is attached to enters a scene
    myInt = MultiplyByTwo(myInt); /* calls function below;
    putting myInt as a parameter gives a useable value to our temporary "number" variable;
    declares that myInt is equal to the result of my function (should be 5*2 or 10) */
    Debug.Log(myInt); // using this, I can see my result in the console window
  }
  // For this example, I am giving my function a type of box to return
  int MultiplyByTwo(int number) { // type FunctionName(type parameterName); number is a temporary variable
    int ret; // ret is a temporary variable for this function
    ret = number * 2; // sets the ret variable equal to the number variable above, multiplied by 2
    return ret; // use return to do an output command; returns the value of the ret variable
  }
}
