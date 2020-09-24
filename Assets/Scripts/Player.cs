using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int health;
    public int damage;

    public Enemy enemy;

    void Start()
    {
        print($"Hello, I'm {name}");
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int enemyHealth = enemy.GetHealth();

            if (enemyHealth > 0)
            {
                enemy.Attack(damage);
            }
            
        }
    }
}
