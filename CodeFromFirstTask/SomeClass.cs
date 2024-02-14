using UnityEngine;
using System.Collections;

public class SomeClass : MonoBehaviour
{
    void Start ()
    {
        transform.ResetTransformation();
    }
    public T GenericMethod<T>(T param)
    {
        return param;
    }
    
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }
    
    public string Add(string str1, string str2)
    {
        return str1 + str2;
    }
}