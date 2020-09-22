using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{

    void Start()
    {
        int playerHealth; // qqqqqqq
        int enemyHealth;
        playerHealth = 40;
        enemyHealth = playerHealth;

        print(playerHealth);
        playerHealth = 0;
        print(playerHealth * 2);
        print(enemyHealth);

        float damage = 4.5f;
        playerHealth = (int) (playerHealth - damage);

        string playerName = "Yuri";
       

        bool isAlive;
        isAlive = false;
        isAlive = playerHealth > 0 && enemyHealth > 0;
        isAlive = playerHealth > 0 || enemyHealth > 0;



        print("Hello " + playerName + playerHealth + isAlive);
        isAlive = false;
        playerHealth = -100;
        if (playerHealth > 0)
            {
                print("ok");
            }
        else
            {
            print("no ok");
        }
    }


    void Update()
    {
        // print("qqq"); 
    }
}
