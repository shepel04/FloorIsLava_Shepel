using UnityEngine;
using System.Collections;


public class Fruit 
{
    public string color;
    
    public Fruit()
    {
        color = "orange";
        Debug.Log("1st Fruit Constructor Called");
    }
    
    public Fruit(string newColor)
    {
        color = newColor;
        Debug.Log("2nd Fruit Constructor Called");
    }

    public virtual void Chop ()
    {
        Debug.Log("The fruit has been chopped.");        
    }

    public virtual void SayHello ()
    {
        Debug.Log("Hello, I am a fruit.");
    }
}