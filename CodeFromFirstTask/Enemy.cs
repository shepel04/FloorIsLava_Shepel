using UnityEngine;
using System.Collections;

public class Enemy : Humanoid   
{
    
    public static int enemyCount = 0;

    public Enemy()
    {
        enemyCount++;
    }
    
    new public void Yell()
    {
        Debug.Log ("Enemy version of the Yell() method");
    }
}