using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour 
{
    void Start () 
    {
        MyPlayer myPlayer = new MyPlayer();

        myPlayer.Experience = 5;
        int exp = myPlayer.Experience;
        
        Enemy enemy1 = new Enemy();
        Enemy enemy2 = new Enemy();
        Enemy enemy3 = new Enemy();
        
        int x = Enemy.enemyCount;
    }
}