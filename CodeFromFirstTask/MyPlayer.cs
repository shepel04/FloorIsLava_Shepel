using UnityEngine;
using System.Collections;

public class MyPlayer
{
   
    public static int playerCount = 0;
    private int experience;
    
    void Start()
    {
        playerCount++;
    }
    
    public int Experience
    {
        get
        {
            return experience;
        }
        set
        {
            experience = value;
        }
    }

    
    public int Level
    {
        get
        {
            return experience / 1000;
        }
        set
        {
            experience = value * 1000;
        }
    }

    
    public int Health{ get; set;}
}