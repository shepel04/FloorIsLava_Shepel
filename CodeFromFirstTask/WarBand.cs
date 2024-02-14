using UnityEngine;
using System.Collections;

public class WarBand : MonoBehaviour 
{
    void Start () 
    {
        Humanoid human = new Humanoid();
        Humanoid enemy = new Enemy();
        Humanoid orc = new Orc();
        
        human.Yell();
        enemy.Yell();
        orc.Yell();
    }
}