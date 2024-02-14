using UnityEngine;
using System.Collections;

public class SomeOtherClass : MonoBehaviour 
{
    void Start () 
    {
        SomeClass myClass = new SomeClass();
        
        myClass.Add (1, 2);
        myClass.Add ("Hello ", "World");
        
        SomeClass myClass2 = new SomeClass();
        myClass2.GenericMethod<int>(5);
    }
}