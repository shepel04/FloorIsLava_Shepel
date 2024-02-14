using UnityEngine;
using System.Collections;


public class Apple : Fruit 
{
    public Apple()
    {
       
        color = "red";
        Debug.Log("1st Apple Constructor Called");
    }

    public Apple(string newColor) : base(newColor)
    {
        Debug.Log("2nd Apple Constructor Called");
    }
    
    public override void Chop ()
    {
        base.Chop();
        Debug.Log("The apple has been chopped.");        
    }

    public override void SayHello ()
    {
        base.SayHello();
        Debug.Log("Hello, I am an apple.");
    }
}