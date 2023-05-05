using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassTest : MonoBehaviour
{
    public Enemy enemy;
    void Start()
    {
        enemy = new Enemy(100,60,200);

        //enemy = new Enemy();
        //enemy.Health = 100;
        //enemy.ShowHelath();
        //Enemy enemy2 = new Enemy();
        //enemy2.Health = 40;
        //enemy2.ShowHelath();
    }

    private void Update()
    {
        
    }

}
