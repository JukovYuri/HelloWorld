using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public int damage;

    void Start()
    {
        print($"Hello, I'm {name}");
    }


    public void Attack(int damageParam)
    {

        health -= damageParam;
        print($"Health life {health}");
        if (health <= 0)
           {
                print($"{name} dead");
           }
    }

    public int GetHealth()
        {
            return health;
        }

     void Update()
    {
        
    }
}
