
using System;

class HelloWorld {
  static void Main (string [] args){
    
    // create variable
    string name = "Jhon";

    Console.WriteLine("name: " + name);

    // variable that store number
    int myNum = 5;
    Console.WriteLine("number: " + myNum);

    // declare an assign value
    int num;
    num = 15;
    Console.WriteLine("declare and assing value=> num: " + num);

    //constants
    const int myConst = 15;
    Console.WriteLine("Constant: " + myConst);

    // multiple variables
    int x = 5, z= 50;
    Console.WriteLine(x+z);    
    // same value
    int a,b,c;
    a = b = c = 45;
    Console.WriteLine("variables, a, b, c: " + a + b + c);
    
    
    
  }
}